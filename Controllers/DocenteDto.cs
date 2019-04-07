using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Controllers
{
    public class DocenteDto
    {
        public int IdDocente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }

        public BindingList<DocenteDto> ListarDocentes()
        {
            try
            {
                using (PortafolioEntities db = new PortafolioEntities())
                {
                    var list = (from u in db.Docente
                                select new DocenteDto
                                {
                                    IdDocente = u.IdDocente,
                                    Nombre = u.Nombre,
                                    Apellidos = u.Apellidos,
                                    Email = u.Email
                                }).ToList();
                    return new BindingList<DocenteDto>(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new BindingList<DocenteDto>();
            }
        }

        public void ActualizarDocente(List<DocenteDto> insert, List<DocenteDto> update, List<DocenteDto> delete)
        {
            try
            {
                using (PortafolioEntities db = new PortafolioEntities())
                {
                    foreach (DocenteDto _u in insert)
                    {
                        Docente e = new Docente()
                        {
                            Nombre = _u.Nombre,
                            Apellidos = _u.Apellidos,
                            Email = _u.Email
                        };
                        db.Docente.Add(e);
                    }
                    foreach (DocenteDto _u in update)
                    {
                        Docente e = (from n in db.Docente
                                     where n.IdDocente == _u.IdDocente
                                     select n).FirstOrDefault();

                        e.Nombre = _u.Nombre;
                        e.Apellidos = _u.Apellidos;
                        e.Email = _u.Email;

                        db.Entry(e).CurrentValues.SetValues(e);

                    }
                    foreach (DocenteDto _u in delete)
                    {
                        Docente e = (from n in db.Docente
                                     where n.IdDocente == _u.IdDocente
                                     select n).FirstOrDefault();

                        db.Docente.Remove(e);
                    }

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

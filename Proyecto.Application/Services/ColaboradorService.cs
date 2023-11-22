using Proyecto.Application.Contracts;
using Proyecto.Application.Contracts.Repositories;
using Proyecto.Domain.DTOs.Colaboradores;
using Entities = Proyecto.Domain.EntityModels.Colaboradores;
using Proyecto.Domain.InputModels.Colaborador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Application.Services
{
    public class ColaboradorService : IColaboradorService
    {

        private readonly IColaboradorRepository _repository;

        public ColaboradorService(IColaboradorRepository _repository)
        {
            this._repository = _repository;
        }

        public Colaborador Get(int id)
        {
            var colaborador = _repository.Get(s => s.Id == id);
            return new Colaborador(colaborador.Id, colaborador.NombreColaborador, colaborador.ApellidoColaborador,
                colaborador.CedulaColaborador, colaborador.CorreoElectronico, colaborador.NumeroTelefono, colaborador.DireccionColaborador, colaborador.SalarioColaborador);
        }

        public Colaborador GetByCedula(string cedula)
        {
            var colaborador = _repository.Get(c => c.CedulaColaborador == cedula);
            return new Colaborador(colaborador.Id, colaborador.NombreColaborador, colaborador.ApellidoColaborador,
                colaborador.CedulaColaborador, colaborador.CorreoElectronico, colaborador.NumeroTelefono, colaborador.DireccionColaborador, colaborador.SalarioColaborador);
        }

        public List<Colaborador> List()
        {
            return _repository.GetAll().ToList()
                .ConvertAll(colaborador => new Colaborador(colaborador.Id, colaborador.NombreColaborador, colaborador.ApellidoColaborador,
                colaborador.CedulaColaborador, colaborador.CorreoElectronico, colaborador.NumeroTelefono, colaborador.DireccionColaborador, colaborador.SalarioColaborador));
        }


        public bool Insert(NuevoColaborador newColaborador)
        {
            Entities.Colaborador Colaborador = new Entities.Colaborador(newColaborador.NombreColaborador, newColaborador.ApellidoColaborador);
            Colaborador.SetAdditionalInfo(newColaborador.CedulaColaborador, newColaborador.CorreoElectronico, newColaborador.NumeroTelefono, newColaborador.DireccionColaborador, newColaborador.SalarioColaborador);
            _repository.Insert(Colaborador);
            _repository.Save();
            return true;
        }

        public bool Update(ColaboradorExistente colaboradorExistente)
        {
            Entities.Colaborador colaborador = _repository.Get(s => s.Id == colaboradorExistente.Id);
            colaborador.Update(colaboradorExistente.NombreColaborador, colaboradorExistente.ApellidoColaborador, colaboradorExistente.CedulaColaborador, colaboradorExistente.CorreoElectronico,
                colaboradorExistente.NumeroTelefono, colaboradorExistente.DireccionColaborador, colaboradorExistente.SalarioColaborador);
            _repository.Update(colaborador);
            _repository.Save();
            return true;
        }

        public bool Delete(int id)
        {
            Entities.Colaborador Colaborador = _repository.Get(s => s.Id == id);
            _repository.Delete(Colaborador);
            _repository.Save();
            return true;
        }


    }
}

using Proyecto.Application.Contracts;
using Proyecto.Application.Contracts.Repositories;
using Proyecto.Domain.DTOs.Clientes;
using Entities = Proyecto.Domain.EntityModels.Cliente;
using Proyecto.Domain.InputModels.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Application.Services
{
    public class ClienteService : IClienteService
    {

        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository _repository)
        {
            this._repository = _repository;
        }

        public Cliente Get(int id)
        {
            var cliente = _repository.Get(s => s.Id == id);
            return new Cliente(cliente.Id, cliente.NombreCliente, cliente.ApellidoCliente,
                cliente.CedulaCliente, cliente.CorreoElectronico, cliente.NumeroTelefono, cliente.DireccionCliente);
        }

        public Cliente GetByCedula(string cedula)
        {
            var cliente = _repository.Get(c => c.CedulaCliente == cedula);
            return new Cliente(cliente.Id, cliente.NombreCliente, cliente.ApellidoCliente,
                cliente.CedulaCliente, cliente.CorreoElectronico, cliente.NumeroTelefono, cliente.DireccionCliente);
        }

        public List<Cliente> List()
        {
            return _repository.GetAll().ToList()
                .ConvertAll(cliente => new Cliente(cliente.Id, cliente.NombreCliente, cliente.ApellidoCliente,
                cliente.CedulaCliente, cliente.CorreoElectronico, cliente.NumeroTelefono, cliente.DireccionCliente));
        }


        public bool Insert(NuevoCliente newCliente)
        {
            Entities.Cliente cliente = new Entities.Cliente(newCliente.NombreCliente, newCliente.ApellidoCliente);
            cliente.SetAdditionalInfo(newCliente.CedulaCliente, newCliente.CorreoElectronico, newCliente.NumeroTelefono, newCliente.DireccionCliente);
            _repository.Insert(cliente);
            _repository.Save();
            return true;
        }

        public bool Update(ClienteExistente clienteExistente)
        {
            Entities.Cliente cliente = _repository.Get(s => s.Id == clienteExistente.Id);
            cliente.Update(clienteExistente.NombreCliente, clienteExistente.ApellidoCliente, clienteExistente.CedulaCliente, clienteExistente.CorreoElectronico, clienteExistente.NumeroTelefono, clienteExistente.DireccionCliente);
            _repository.Update(cliente);
            _repository.Save();
            return true;
        }

        public bool Delete(int id)
        {
            Entities.Cliente cliente = _repository.Get(s => s.Id == id);
            _repository.Delete(cliente);
            _repository.Save();
            return true;
        }


    }
}

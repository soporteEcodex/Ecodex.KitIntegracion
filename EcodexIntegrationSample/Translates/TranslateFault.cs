using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcodexIntegrationSample
{
    internal class TranslateFault
    {
        public static Entity.ServiceError ToServiceError(SrvSecurity.FallaServicio from)
        {
            var to = new Entity.ServiceError
            {
                RFC = from.RFC,
                Number = from.Numero,
                Description = from.Descripcion,
                EventID = from.Evento
            };
            return to;
        }

        public static Entity.ServiceError ToServiceError(SrvInvoices.FallaServicio from)
        {
            var to = new Entity.ServiceError
            {
                RFC = from.RFC,
                Number = from.Numero,
                Description = from.Descripcion,
                EventID = from.Evento
            };
            return to;
        }
        public static Entity.ServiceError ToServiceError(SrvTimbrado.FallaServicio from)
        {
            var to = new Entity.ServiceError
            {
                RFC = from.RFC,
                Number = from.Numero,
                Description = from.Descripcion,
                EventID = from.Evento
            };
            return to;
        }
        public static Entity.ServiceError ToServiceError(SrvRepository.FallaServicio from)
        {
            var to = new Entity.ServiceError
            {
                RFC = from.RFC,
                Number = from.Numero,
                Description = from.Descripcion,
                EventID = from.Evento
            };
            return to;
        }
        public static Entity.ServiceError ToServiceError(SrvClients.FallaServicio from)
        {
            var to = new Entity.ServiceError
            {
                RFC = from.RFC,
                Number = from.Numero,
                Description = from.Descripcion,
                EventID = from.Evento
            };
            return to;
        }

        public static Entity.SessionError ToSessionError(SrvSecurity.FallaSesion from)
        {
            var to = new Entity.SessionError
            {
                RFC = from.RFC,
                Status = from.Estatus,
                Description = from.Descripcion
            };
            return to;
        }

        public static Entity.SessionError ToSessionError(SrvInvoices.FallaSesion from)
        {
            var to = new Entity.SessionError
            {
                RFC = from.RFC,
                Status = from.Estatus,
                Description = from.Descripcion
            };
            return to;
        }
        public static Entity.SessionError ToSessionError(SrvTimbrado.FallaSesion from)
        {
            var to = new Entity.SessionError
            {
                RFC = from.RFC,
                Status = from.Estatus,
                Description = from.Descripcion
            };
            return to;
        }

        public static Entity.SessionError ToSessionError(SrvRepository.FallaSesion from)
        {
            var to = new Entity.SessionError
            {
                RFC = from.RFC,
                Status = from.Estatus,
                Description = from.Descripcion
            };
            return to;
        }
        public static Entity.SessionError ToSessionError(SrvClients.FallaSesion from)
        {
            var to = new Entity.SessionError
            {
                RFC = from.RFC,
                Status = from.Estatus,
                Description = from.Descripcion
            };
            return to;
        }
        public static Entity.ValidationError ToValidationError(SrvInvoices.FallaValidacion from)
        {
            var to = new Entity.ValidationError
            {
                RFC = from.RFC,
                Number = from.Numero,
                Description = from.Descripcion,
                Node = from.Nodo,
                Antecedent = from.Antecedente,
                Suggestion = from.Sugerencia,
                EventID = from.Evento
            };
            return to;
        }
        public static Entity.ValidationError ToValidationError(SrvTimbrado.FallaValidacion from)
        {
            var to = new Entity.ValidationError
            {
                RFC = from.RFC,
                Number = from.Numero,
                Description = from.Descripcion,
                Node = from.Nodo,
                Antecedent = from.Antecedente,
                Suggestion = from.Sugerencia,
                EventID = from.Evento
            };
            return to;
        }
    }
}

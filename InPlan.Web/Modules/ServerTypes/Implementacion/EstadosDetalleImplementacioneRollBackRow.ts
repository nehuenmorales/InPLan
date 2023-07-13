import { fieldsProxy } from "@serenity-is/corelib/q";

export interface EstadosDetalleImplementacioneRollBackRow {
    IdEstadoDetalleImplementacionRollBack?: number;
    IdDetalleImplementacionRollBack?: number;
    IdEstadoTarea?: number;
    IdTecnicoTarea?: number;
    FechaEstado?: string;
    FechaCarga?: string;
    NotasAdicionales?: string;
    DocumentosAdicionales?: string;
    Observaciones?: string;
    UserId?: number;
    IdDetalleImplementacionRollBackOrden?: string;
    IdEstadoTareaDescripcion?: string;
    IdTecnicoTareaNombreCompleto?: string;
    Username?: string;
}

export abstract class EstadosDetalleImplementacioneRollBackRow {
    static readonly idProperty = 'IdEstadoDetalleImplementacionRollBack';
    static readonly nameProperty = 'NotasAdicionales';
    static readonly localTextPrefix = 'Implementacion.EstadosDetalleImplementacioneRollBack';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<EstadosDetalleImplementacioneRollBackRow>();
}
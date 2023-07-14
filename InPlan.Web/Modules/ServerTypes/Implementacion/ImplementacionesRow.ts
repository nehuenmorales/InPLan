import { DetalleImplementacionesRow } from "./DetalleImplementacionesRow";
import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface ImplementacionesRow {
    IdImplementacion?: number;
    IdProyecto?: number;
    IdAmbienteProyecto?: number;
    IdTecnicoSolicitante?: number;
    IdTecnicoImplementa?: number;
    IdTipoImplementacion?: number;
    NroTicket?: string;
    FechaSolicitud?: string;
    FechaPlanificada?: string;
    FechaImplementacion?: string;
    ConsideracionesPrevias?: string;
    Descripcion?: string;
    ConsideracionesPosteriores?: string;
    NotasAdicionales?: string;
    DocumentosAdicionales?: string;
    Observaciones?: string;
    UserId?: number;
    IdProyectoNombreProyecto?: string;
    IdAmbienteProyectoServidorDatos?: string;
    IdTecnicoSolicitanteNombreCompleto?: string;
    IdTecnicoImplementaNombreCompleto?: string;
    IdTipoImplementacionDescripcion?: string;
    Username?: string;
    DetallesList?: DetalleImplementacionesRow[];
}

export abstract class ImplementacionesRow {
    static readonly idProperty = 'IdImplementacion';
    static readonly nameProperty = 'NroTicket';
    static readonly localTextPrefix = 'Implementacion.Implementaciones';
    static readonly lookupKey = 'Implementacion.Implementaciones';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ImplementacionesRow>('Implementacion.Implementaciones') }
    static async getLookupAsync() { return getLookupAsync<ImplementacionesRow>('Implementacion.Implementaciones') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ImplementacionesRow>();
}
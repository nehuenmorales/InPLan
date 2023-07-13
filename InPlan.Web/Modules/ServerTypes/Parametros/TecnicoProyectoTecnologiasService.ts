import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { TecnicoProyectoTecnologiasRow } from "./TecnicoProyectoTecnologiasRow";

export namespace TecnicoProyectoTecnologiasService {
    export const baseUrl = 'Parametros/TecnicoProyectoTecnologias';

    export declare function Create(request: SaveRequest<TecnicoProyectoTecnologiasRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<TecnicoProyectoTecnologiasRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TecnicoProyectoTecnologiasRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TecnicoProyectoTecnologiasRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Parametros/TecnicoProyectoTecnologias/Create",
        Update: "Parametros/TecnicoProyectoTecnologias/Update",
        Delete: "Parametros/TecnicoProyectoTecnologias/Delete",
        Retrieve: "Parametros/TecnicoProyectoTecnologias/Retrieve",
        List: "Parametros/TecnicoProyectoTecnologias/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>TecnicoProyectoTecnologiasService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { ProyectosTecnologiasRow } from "./ProyectosTecnologiasRow";

export namespace ProyectosTecnologiasService {
    export const baseUrl = 'Parametros/ProyectosTecnologias';

    export declare function Create(request: SaveRequest<ProyectosTecnologiasRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<ProyectosTecnologiasRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ProyectosTecnologiasRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ProyectosTecnologiasRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Parametros/ProyectosTecnologias/Create",
        Update: "Parametros/ProyectosTecnologias/Update",
        Delete: "Parametros/ProyectosTecnologias/Delete",
        Retrieve: "Parametros/ProyectosTecnologias/Retrieve",
        List: "Parametros/ProyectosTecnologias/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ProyectosTecnologiasService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
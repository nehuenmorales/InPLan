import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { TecnicosProyectosRow } from "./TecnicosProyectosRow";

export namespace TecnicosProyectosService {
    export const baseUrl = 'Parametros/TecnicosProyectos';

    export declare function Create(request: SaveRequest<TecnicosProyectosRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<TecnicosProyectosRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TecnicosProyectosRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TecnicosProyectosRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Parametros/TecnicosProyectos/Create",
        Update: "Parametros/TecnicosProyectos/Update",
        Delete: "Parametros/TecnicosProyectos/Delete",
        Retrieve: "Parametros/TecnicosProyectos/Retrieve",
        List: "Parametros/TecnicosProyectos/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>TecnicosProyectosService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
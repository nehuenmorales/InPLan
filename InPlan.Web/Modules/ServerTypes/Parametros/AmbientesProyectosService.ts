import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { AmbientesProyectosRow } from "./AmbientesProyectosRow";

export namespace AmbientesProyectosService {
    export const baseUrl = 'Parametros/AmbientesProyectos';

    export declare function Create(request: SaveRequest<AmbientesProyectosRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<AmbientesProyectosRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AmbientesProyectosRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AmbientesProyectosRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Parametros/AmbientesProyectos/Create",
        Update: "Parametros/AmbientesProyectos/Update",
        Delete: "Parametros/AmbientesProyectos/Delete",
        Retrieve: "Parametros/AmbientesProyectos/Retrieve",
        List: "Parametros/AmbientesProyectos/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AmbientesProyectosService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
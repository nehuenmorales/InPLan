import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { EstadosDetalleImplementacionesRow } from "./EstadosDetalleImplementacionesRow";

export namespace EstadosDetalleImplementacionesService {
    export const baseUrl = 'Implementacion/EstadosDetalleImplementaciones';

    export declare function Create(request: SaveRequest<EstadosDetalleImplementacionesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<EstadosDetalleImplementacionesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<EstadosDetalleImplementacionesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<EstadosDetalleImplementacionesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Implementacion/EstadosDetalleImplementaciones/Create",
        Update: "Implementacion/EstadosDetalleImplementaciones/Update",
        Delete: "Implementacion/EstadosDetalleImplementaciones/Delete",
        Retrieve: "Implementacion/EstadosDetalleImplementaciones/Retrieve",
        List: "Implementacion/EstadosDetalleImplementaciones/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>EstadosDetalleImplementacionesService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
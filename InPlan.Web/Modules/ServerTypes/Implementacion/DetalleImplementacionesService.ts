import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { DetalleImplementacionesRow } from "./DetalleImplementacionesRow";

export namespace DetalleImplementacionesService {
    export const baseUrl = 'Implementacion/DetalleImplementaciones';

    export declare function Create(request: SaveRequest<DetalleImplementacionesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<DetalleImplementacionesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<DetalleImplementacionesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<DetalleImplementacionesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Implementacion/DetalleImplementaciones/Create",
        Update: "Implementacion/DetalleImplementaciones/Update",
        Delete: "Implementacion/DetalleImplementaciones/Delete",
        Retrieve: "Implementacion/DetalleImplementaciones/Retrieve",
        List: "Implementacion/DetalleImplementaciones/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>DetalleImplementacionesService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
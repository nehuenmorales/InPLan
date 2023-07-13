import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { DetalleImplementacionesRollBackRow } from "./DetalleImplementacionesRollBackRow";

export namespace DetalleImplementacionesRollBackService {
    export const baseUrl = 'Implementacion/DetalleImplementacionesRollBack';

    export declare function Create(request: SaveRequest<DetalleImplementacionesRollBackRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<DetalleImplementacionesRollBackRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<DetalleImplementacionesRollBackRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<DetalleImplementacionesRollBackRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Implementacion/DetalleImplementacionesRollBack/Create",
        Update: "Implementacion/DetalleImplementacionesRollBack/Update",
        Delete: "Implementacion/DetalleImplementacionesRollBack/Delete",
        Retrieve: "Implementacion/DetalleImplementacionesRollBack/Retrieve",
        List: "Implementacion/DetalleImplementacionesRollBack/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>DetalleImplementacionesRollBackService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
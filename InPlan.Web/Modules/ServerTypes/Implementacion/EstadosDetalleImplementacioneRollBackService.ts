import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { EstadosDetalleImplementacioneRollBackRow } from "./EstadosDetalleImplementacioneRollBackRow";

export namespace EstadosDetalleImplementacioneRollBackService {
    export const baseUrl = 'Implementacion/EstadosDetalleImplementacioneRollBack';

    export declare function Create(request: SaveRequest<EstadosDetalleImplementacioneRollBackRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<EstadosDetalleImplementacioneRollBackRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<EstadosDetalleImplementacioneRollBackRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<EstadosDetalleImplementacioneRollBackRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Implementacion/EstadosDetalleImplementacioneRollBack/Create",
        Update: "Implementacion/EstadosDetalleImplementacioneRollBack/Update",
        Delete: "Implementacion/EstadosDetalleImplementacioneRollBack/Delete",
        Retrieve: "Implementacion/EstadosDetalleImplementacioneRollBack/Retrieve",
        List: "Implementacion/EstadosDetalleImplementacioneRollBack/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>EstadosDetalleImplementacioneRollBackService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
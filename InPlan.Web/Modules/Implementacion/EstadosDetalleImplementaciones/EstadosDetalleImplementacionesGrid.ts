import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { EstadosDetalleImplementacionesColumns, EstadosDetalleImplementacionesRow, EstadosDetalleImplementacionesService } from '../../ServerTypes/Implementacion';
import { EstadosDetalleImplementacionesDialog } from './EstadosDetalleImplementacionesDialog';

@Decorators.registerClass('InPlan.Implementacion.EstadosDetalleImplementacionesGrid')
export class EstadosDetalleImplementacionesGrid extends EntityGrid<EstadosDetalleImplementacionesRow, any> {
    protected getColumnsKey() { return EstadosDetalleImplementacionesColumns.columnsKey; }
    protected getDialogType() { return EstadosDetalleImplementacionesDialog; }
    protected getRowDefinition() { return EstadosDetalleImplementacionesRow; }
    protected getService() { return EstadosDetalleImplementacionesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}
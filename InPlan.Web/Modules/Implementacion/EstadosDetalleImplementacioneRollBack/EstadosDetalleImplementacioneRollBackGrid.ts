import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { EstadosDetalleImplementacioneRollBackColumns, EstadosDetalleImplementacioneRollBackRow, EstadosDetalleImplementacioneRollBackService } from '../../ServerTypes/Implementacion';
import { EstadosDetalleImplementacioneRollBackDialog } from './EstadosDetalleImplementacioneRollBackDialog';

@Decorators.registerClass('InPlan.Implementacion.EstadosDetalleImplementacioneRollBackGrid')
export class EstadosDetalleImplementacioneRollBackGrid extends EntityGrid<EstadosDetalleImplementacioneRollBackRow, any> {
    protected getColumnsKey() { return EstadosDetalleImplementacioneRollBackColumns.columnsKey; }
    protected getDialogType() { return EstadosDetalleImplementacioneRollBackDialog; }
    protected getRowDefinition() { return EstadosDetalleImplementacioneRollBackRow; }
    protected getService() { return EstadosDetalleImplementacioneRollBackService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DetalleImplementacionesRollBackColumns, DetalleImplementacionesRollBackRow, DetalleImplementacionesRollBackService } from '../../ServerTypes/Implementacion';
import { DetalleImplementacionesRollBackDialog } from './DetalleImplementacionesRollBackDialog';

@Decorators.registerClass('InPlan.Implementacion.DetalleImplementacionesRollBackGrid')
export class DetalleImplementacionesRollBackGrid extends EntityGrid<DetalleImplementacionesRollBackRow, any> {
    protected getColumnsKey() { return DetalleImplementacionesRollBackColumns.columnsKey; }
    protected getDialogType() { return DetalleImplementacionesRollBackDialog; }
    protected getRowDefinition() { return DetalleImplementacionesRollBackRow; }
    protected getService() { return DetalleImplementacionesRollBackService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}
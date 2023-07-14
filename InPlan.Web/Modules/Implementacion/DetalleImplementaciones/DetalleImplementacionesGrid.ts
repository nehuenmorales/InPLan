import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DetalleImplementacionesColumns, DetalleImplementacionesRow, DetalleImplementacionesService } from '../../ServerTypes/Implementacion';
import { DetalleImplementacionesDialog } from './DetalleImplementacionesDialog';

@Decorators.registerClass('InPlan.Implementacion.DetalleImplementacionesGrid')
export class DetalleImplementacionesGrid extends EntityGrid<DetalleImplementacionesRow, any> {
    protected getColumnsKey() { return DetalleImplementacionesColumns.columnsKey; }
    protected getDialogType() { return DetalleImplementacionesDialog; }
    protected getRowDefinition() { return DetalleImplementacionesRow; }
    protected getService() { return DetalleImplementacionesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}
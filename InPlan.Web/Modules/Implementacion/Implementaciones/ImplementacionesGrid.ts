import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ImplementacionesColumns, ImplementacionesRow, ImplementacionesService } from '../../ServerTypes/Implementacion';
import { ImplementacionesDialog } from './ImplementacionesDialog';

@Decorators.registerClass('InPlan.Implementacion.ImplementacionesGrid')
export class ImplementacionesGrid extends EntityGrid<ImplementacionesRow, any> {
    protected getColumnsKey() { return ImplementacionesColumns.columnsKey; }
    protected getDialogType() { return ImplementacionesDialog; }
    protected getRowDefinition() { return ImplementacionesRow; }
    protected getService() { return ImplementacionesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
    protected getButtons() {
        const buttons = super.getButtons();

        buttons.map(b => {
            if (b.action == "add") b.title = "Nueva Implementación"
            return b
        })
        return buttons
    }
}
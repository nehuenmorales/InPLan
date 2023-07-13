import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AmbientesColumns, AmbientesRow, AmbientesService } from '../../ServerTypes/Parametros';
import { AmbientesDialog } from './AmbientesDialog';

@Decorators.registerClass('InPlan.Parametros.AmbientesGrid')
export class AmbientesGrid extends EntityGrid<AmbientesRow, any> {
    protected getColumnsKey() { return AmbientesColumns.columnsKey; }
    protected getDialogType() { return AmbientesDialog; }
    protected getRowDefinition() { return AmbientesRow; }
    protected getService() { return AmbientesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}
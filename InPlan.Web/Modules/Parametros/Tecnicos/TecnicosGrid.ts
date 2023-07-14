import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TecnicosColumns, TecnicosRow, TecnicosService } from '../../ServerTypes/Parametros';
import { TecnicosDialog } from './TecnicosDialog';

@Decorators.registerClass('InPlan.Parametros.TecnicosGrid')
export class TecnicosGrid extends EntityGrid<TecnicosRow, any> {
    protected getColumnsKey() { return TecnicosColumns.columnsKey; }
    protected getDialogType() { return TecnicosDialog; }
    protected getRowDefinition() { return TecnicosRow; }
    protected getService() { return TecnicosService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}
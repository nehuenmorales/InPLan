import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TiposImplementacionColumns, TiposImplementacionRow, TiposImplementacionService } from '../../ServerTypes/Implementacion';
import { TiposImplementacionDialog } from './TiposImplementacionDialog';

@Decorators.registerClass('InPlan.Implementacion.TiposImplementacionGrid')
export class TiposImplementacionGrid extends EntityGrid<TiposImplementacionRow, any> {
    protected getColumnsKey() { return TiposImplementacionColumns.columnsKey; }
    protected getDialogType() { return TiposImplementacionDialog; }
    protected getRowDefinition() { return TiposImplementacionRow; }
    protected getService() { return TiposImplementacionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}
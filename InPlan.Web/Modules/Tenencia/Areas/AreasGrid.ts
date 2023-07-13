import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AreasColumns, AreasRow, AreasService } from '../../ServerTypes/Tenencia';
import { AreasDialog } from './AreasDialog';

@Decorators.registerClass('InPlan.Tenencia.AreasGrid')
export class AreasGrid extends EntityGrid<AreasRow, any> {
    protected getColumnsKey() { return AreasColumns.columnsKey; }
    protected getDialogType() { return AreasDialog; }
    protected getRowDefinition() { return AreasRow; }
    protected getService() { return AreasService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { EmpresasColumns, EmpresasRow, EmpresasService } from '../../ServerTypes/Tenencia';
import { EmpresasDialog } from './EmpresasDialog';

@Decorators.registerClass('InPlan.Tenencia.EmpresasGrid')
export class EmpresasGrid extends EntityGrid<EmpresasRow, any> {
    protected getColumnsKey() { return EmpresasColumns.columnsKey; }
    protected getDialogType() { return EmpresasDialog; }
    protected getRowDefinition() { return EmpresasRow; }
    protected getService() { return EmpresasService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}
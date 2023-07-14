import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ClientesColumns, ClientesRow, ClientesService } from '../../ServerTypes/Parametros';
import { ClientesDialog } from './ClientesDialog';

@Decorators.registerClass('InPlan.Parametros.ClientesGrid')
export class ClientesGrid extends EntityGrid<ClientesRow, any> {
    protected getColumnsKey() { return ClientesColumns.columnsKey; }
    protected getDialogType() { return ClientesDialog; }
    protected getRowDefinition() { return ClientesRow; }
    protected getService() { return ClientesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}
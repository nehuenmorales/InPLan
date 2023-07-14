import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ClientesForm, ClientesRow, ClientesService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('InPlan.Parametros.ClientesDialog')
export class ClientesDialog extends EntityDialog<ClientesRow, any> {
    protected getFormKey() { return ClientesForm.formKey; }
    protected getRowDefinition() { return ClientesRow; }
    protected getService() { return ClientesService.baseUrl; }

    protected form = new ClientesForm(this.idPrefix);
}
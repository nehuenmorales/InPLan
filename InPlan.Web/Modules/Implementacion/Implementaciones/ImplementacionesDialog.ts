import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ImplementacionesForm, ImplementacionesRow, ImplementacionesService } from '../../ServerTypes/Implementacion';

@Decorators.registerClass('InPlan.Implementacion.ImplementacionesDialog')
export class ImplementacionesDialog extends EntityDialog<ImplementacionesRow, any> {
    protected getFormKey() { return ImplementacionesForm.formKey; }
    protected getRowDefinition() { return ImplementacionesRow; }
    protected getService() { return ImplementacionesService.baseUrl; }

    protected form = new ImplementacionesForm(this.idPrefix);
}
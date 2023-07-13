import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { DetalleImplementacionesForm, DetalleImplementacionesRow, DetalleImplementacionesService } from '../../ServerTypes/Implementacion';

@Decorators.registerClass('InPlan.Implementacion.DetalleImplementacionesDialog')
export class DetalleImplementacionesDialog extends EntityDialog<DetalleImplementacionesRow, any> {
    protected getFormKey() { return DetalleImplementacionesForm.formKey; }
    protected getRowDefinition() { return DetalleImplementacionesRow; }
    protected getService() { return DetalleImplementacionesService.baseUrl; }

    protected form = new DetalleImplementacionesForm(this.idPrefix);
}
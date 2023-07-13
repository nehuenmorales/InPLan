import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { DetalleImplementacionesRollBackForm, DetalleImplementacionesRollBackRow, DetalleImplementacionesRollBackService } from '../../ServerTypes/Implementacion';

@Decorators.registerClass('InPlan.Implementacion.DetalleImplementacionesRollBackDialog')
export class DetalleImplementacionesRollBackDialog extends EntityDialog<DetalleImplementacionesRollBackRow, any> {
    protected getFormKey() { return DetalleImplementacionesRollBackForm.formKey; }
    protected getRowDefinition() { return DetalleImplementacionesRollBackRow; }
    protected getService() { return DetalleImplementacionesRollBackService.baseUrl; }

    protected form = new DetalleImplementacionesRollBackForm(this.idPrefix);
}
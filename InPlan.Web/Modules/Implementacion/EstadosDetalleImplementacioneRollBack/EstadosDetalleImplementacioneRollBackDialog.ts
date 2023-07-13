import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { EstadosDetalleImplementacioneRollBackForm, EstadosDetalleImplementacioneRollBackRow, EstadosDetalleImplementacioneRollBackService } from '../../ServerTypes/Implementacion';

@Decorators.registerClass('InPlan.Implementacion.EstadosDetalleImplementacioneRollBackDialog')
export class EstadosDetalleImplementacioneRollBackDialog extends EntityDialog<EstadosDetalleImplementacioneRollBackRow, any> {
    protected getFormKey() { return EstadosDetalleImplementacioneRollBackForm.formKey; }
    protected getRowDefinition() { return EstadosDetalleImplementacioneRollBackRow; }
    protected getService() { return EstadosDetalleImplementacioneRollBackService.baseUrl; }

    protected form = new EstadosDetalleImplementacioneRollBackForm(this.idPrefix);
}
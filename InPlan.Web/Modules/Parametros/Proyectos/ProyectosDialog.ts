import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ProyectosForm, ProyectosRow, ProyectosService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('InPlan.Parametros.ProyectosDialog')
export class ProyectosDialog extends EntityDialog<ProyectosRow, any> {
    protected getFormKey() { return ProyectosForm.formKey; }
    protected getRowDefinition() { return ProyectosRow; }
    protected getService() { return ProyectosService.baseUrl; }

    protected form = new ProyectosForm(this.idPrefix);
}
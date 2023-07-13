import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ProyectosTecnologiasForm, ProyectosTecnologiasRow, ProyectosTecnologiasService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('InPlan.Parametros.ProyectosTecnologiasDialog')
export class ProyectosTecnologiasDialog extends EntityDialog<ProyectosTecnologiasRow, any> {
    protected getFormKey() { return ProyectosTecnologiasForm.formKey; }
    protected getRowDefinition() { return ProyectosTecnologiasRow; }
    protected getService() { return ProyectosTecnologiasService.baseUrl; }

    protected form = new ProyectosTecnologiasForm(this.idPrefix);
}
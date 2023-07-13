import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { AmbientesProyectosForm, AmbientesProyectosRow, AmbientesProyectosService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('InPlan.Parametros.AmbientesProyectosDialog')
export class AmbientesProyectosDialog extends EntityDialog<AmbientesProyectosRow, any> {
    protected getFormKey() { return AmbientesProyectosForm.formKey; }
    protected getRowDefinition() { return AmbientesProyectosRow; }
    protected getService() { return AmbientesProyectosService.baseUrl; }

    protected form = new AmbientesProyectosForm(this.idPrefix);
}
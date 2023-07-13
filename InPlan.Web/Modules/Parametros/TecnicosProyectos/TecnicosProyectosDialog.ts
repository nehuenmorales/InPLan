import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TecnicosProyectosForm, TecnicosProyectosRow, TecnicosProyectosService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('InPlan.Parametros.TecnicosProyectosDialog')
export class TecnicosProyectosDialog extends EntityDialog<TecnicosProyectosRow, any> {
    protected getFormKey() { return TecnicosProyectosForm.formKey; }
    protected getRowDefinition() { return TecnicosProyectosRow; }
    protected getService() { return TecnicosProyectosService.baseUrl; }

    protected form = new TecnicosProyectosForm(this.idPrefix);
}
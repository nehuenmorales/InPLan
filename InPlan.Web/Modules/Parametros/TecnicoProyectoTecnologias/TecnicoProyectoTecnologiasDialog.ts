import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TecnicoProyectoTecnologiasForm, TecnicoProyectoTecnologiasRow, TecnicoProyectoTecnologiasService } from '../../ServerTypes/Parametros';

@Decorators.registerClass('InPlan.Parametros.TecnicoProyectoTecnologiasDialog')
export class TecnicoProyectoTecnologiasDialog extends EntityDialog<TecnicoProyectoTecnologiasRow, any> {
    protected getFormKey() { return TecnicoProyectoTecnologiasForm.formKey; }
    protected getRowDefinition() { return TecnicoProyectoTecnologiasRow; }
    protected getService() { return TecnicoProyectoTecnologiasService.baseUrl; }

    protected form = new TecnicoProyectoTecnologiasForm(this.idPrefix);
}
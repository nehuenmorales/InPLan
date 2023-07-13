import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { EmpresasForm, EmpresasRow, EmpresasService } from '../../ServerTypes/Tenencia';

@Decorators.registerClass('InPlan.Tenencia.EmpresasDialog')
export class EmpresasDialog extends EntityDialog<EmpresasRow, any> {
    protected getFormKey() { return EmpresasForm.formKey; }
    protected getRowDefinition() { return EmpresasRow; }
    protected getService() { return EmpresasService.baseUrl; }

    protected form = new EmpresasForm(this.idPrefix);
}
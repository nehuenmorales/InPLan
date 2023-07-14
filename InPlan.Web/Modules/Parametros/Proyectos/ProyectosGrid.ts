import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProyectosColumns, ProyectosRow, ProyectosService } from '../../ServerTypes/Parametros';
import { ProyectosDialog } from './ProyectosDialog';

@Decorators.registerClass('InPlan.Parametros.ProyectosGrid')
export class ProyectosGrid extends EntityGrid<ProyectosRow, any> {
    protected getColumnsKey() { return ProyectosColumns.columnsKey; }
    protected getDialogType() { return ProyectosDialog; }
    protected getRowDefinition() { return ProyectosRow; }
    protected getService() { return ProyectosService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}
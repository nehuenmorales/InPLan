import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TecnicosProyectosColumns, TecnicosProyectosRow, TecnicosProyectosService } from '../../ServerTypes/Parametros';
import { TecnicosProyectosDialog } from './TecnicosProyectosDialog';

@Decorators.registerClass('InPlan.Parametros.TecnicosProyectosGrid')
export class TecnicosProyectosGrid extends EntityGrid<TecnicosProyectosRow, any> {
    protected getColumnsKey() { return TecnicosProyectosColumns.columnsKey; }
    protected getDialogType() { return TecnicosProyectosDialog; }
    protected getRowDefinition() { return TecnicosProyectosRow; }
    protected getService() { return TecnicosProyectosService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}
import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TecnicosGrid } from './TecnicosGrid';

export default function pageInit() {
    initFullHeightGridPage(new TecnicosGrid($('#GridDiv')).element);
}
using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.HID.Drivers
{
	// Token: 0x02000119 RID: 281
	public class DualShock4Driver : HIDDeviceDriver
	{
		// Token: 0x06001BCF RID: 7119 RVA: 0x00097BC0 File Offset: 0x00095DC0
		// Note: this type is marked as 'beforefieldinit'.
		static DualShock4Driver()
		{
			Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID.Drivers", "DualShock4Driver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr);
			DualShock4Driver.NativeFieldInfoPtr_cBswOuBTFJaQmJaEsTSUwghjEsxb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "cBswOuBTFJaQmJaEsTSUwghjEsxb");
			DualShock4Driver.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "XQHSiIMpmpLQwAfijbkQiqJbUVm");
			DualShock4Driver.NativeFieldInfoPtr_ZSAekMXsJdpwJeuHzaalTvrqTXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "ZSAekMXsJdpwJeuHzaalTvrqTXZ");
			DualShock4Driver.NativeFieldInfoPtr_xQFBlnjHmSMxSYBxUcplNCrUIpHy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "xQFBlnjHmSMxSYBxUcplNCrUIpHy");
			DualShock4Driver.NativeFieldInfoPtr_DXQOduZMAdakgKHULREouGGIMsj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "DXQOduZMAdakgKHULREouGGIMsj");
			DualShock4Driver.NativeFieldInfoPtr_jkpagfZjLjeageiKHUvdcGIBUyjQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "jkpagfZjLjeageiKHUvdcGIBUyjQ");
			DualShock4Driver.NativeFieldInfoPtr_CbvTpyUAreHQTqRwrRyHFkkvRu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "CbvTpyUAreHQTqRwrRyHFkkvRu");
			DualShock4Driver.NativeFieldInfoPtr_qkfbSOvdxzFTGQsCjAxNayadEWhk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "qkfbSOvdxzFTGQsCjAxNayadEWhk");
			DualShock4Driver.NativeFieldInfoPtr_sstgLgFYucqXUgQCuJWZzpHiirhL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "sstgLgFYucqXUgQCuJWZzpHiirhL");
			DualShock4Driver.NativeFieldInfoPtr_AHJqxkYPMecTbQnOZRgFvJYDGTg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "AHJqxkYPMecTbQnOZRgFvJYDGTg");
			DualShock4Driver.NativeFieldInfoPtr_ykFUEgafLAgAceDkWcqiMSzQgGhj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "ykFUEgafLAgAceDkWcqiMSzQgGhj");
			DualShock4Driver.NativeFieldInfoPtr_ucCwnEJshdgPokipDfKZUPXVGns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "ucCwnEJshdgPokipDfKZUPXVGns");
			DualShock4Driver.NativeFieldInfoPtr_HQywWIGQbJvUyoAzHWTXqleTChs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "HQywWIGQbJvUyoAzHWTXqleTChs");
			DualShock4Driver.NativeFieldInfoPtr_cHNhpgkLYTObmpHxVWxLGMeDyrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "cHNhpgkLYTObmpHxVWxLGMeDyrl");
			DualShock4Driver.NativeFieldInfoPtr_iZucelPQVvvGHDiPkrqCheppWEb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "iZucelPQVvvGHDiPkrqCheppWEb");
			DualShock4Driver.NativeFieldInfoPtr_uxwENVeAtCyNlYtYwbcddIUTAOou = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "uxwENVeAtCyNlYtYwbcddIUTAOou");
			DualShock4Driver.NativeFieldInfoPtr_LgKeAUHCkufZaobBGjJCDaKYadH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "LgKeAUHCkufZaobBGjJCDaKYadH");
			DualShock4Driver.NativeFieldInfoPtr_rTYGvTGnYfwSgAKaOlRpiyzYrWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "rTYGvTGnYfwSgAKaOlRpiyzYrWS");
			DualShock4Driver.NativeFieldInfoPtr_FXtDWUVkUWyrNZDVfPmoAYzjdSk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "FXtDWUVkUWyrNZDVfPmoAYzjdSk");
			DualShock4Driver.NativeFieldInfoPtr_wHEacDZJRphkGPCiPiOJlnwszcO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "wHEacDZJRphkGPCiPiOJlnwszcO");
			DualShock4Driver.NativeFieldInfoPtr_KbJfnNWgRWWhYQPqfyOdakWTCzV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "KbJfnNWgRWWhYQPqfyOdakWTCzV");
			DualShock4Driver.NativeFieldInfoPtr_GxwuqUBQlXZIYUGIfFZXGWQpDaP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "GxwuqUBQlXZIYUGIfFZXGWQpDaP");
			DualShock4Driver.NativeFieldInfoPtr_hcBaVJxFQfmUjEoteGSzULttyVK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "hcBaVJxFQfmUjEoteGSzULttyVK");
			DualShock4Driver.NativeFieldInfoPtr_CCVbhVJfxwwdDigIhqkdBPtgRraU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "CCVbhVJfxwwdDigIhqkdBPtgRraU");
			DualShock4Driver.NativeFieldInfoPtr_BBxhpfDMNTIyFeBupCZIVerwBWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "BBxhpfDMNTIyFeBupCZIVerwBWD");
			DualShock4Driver.NativeFieldInfoPtr_DjKakIgesLnAHNafOLmjWaZijsjK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "DjKakIgesLnAHNafOLmjWaZijsjK");
			DualShock4Driver.NativeFieldInfoPtr_foWgjLXVSVMFiWVEEVhFNgtUENi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "foWgjLXVSVMFiWVEEVhFNgtUENi");
			DualShock4Driver.NativeFieldInfoPtr_yNXkfmYzMlAdJuzyPdItIntpuRG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "yNXkfmYzMlAdJuzyPdItIntpuRG");
			DualShock4Driver.NativeFieldInfoPtr_izvXmSrSPbVoCbIocjuxlbdJFKp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "izvXmSrSPbVoCbIocjuxlbdJFKp");
			DualShock4Driver.NativeFieldInfoPtr_geesShSZbWMRDQXWdWhQsuPIYbg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "geesShSZbWMRDQXWdWhQsuPIYbg");
			DualShock4Driver.NativeFieldInfoPtr_EsFJPdDRcznZMMLQtKTzZswcLZN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "EsFJPdDRcznZMMLQtKTzZswcLZN");
			DualShock4Driver.NativeFieldInfoPtr_DfBydhNWOOkPYugrHJaqMYmzYxW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "DfBydhNWOOkPYugrHJaqMYmzYxW");
			DualShock4Driver.NativeFieldInfoPtr_axsAWDoBfYTvKuiIBVCENVMNClI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "axsAWDoBfYTvKuiIBVCENVMNClI");
			DualShock4Driver.NativeFieldInfoPtr_RkmXSIwacUHALbRdEDzDbXwbiNm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "RkmXSIwacUHALbRdEDzDbXwbiNm");
			DualShock4Driver.NativeFieldInfoPtr_zNJxXdOIpKiDcgASoCbBJWVmwUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "zNJxXdOIpKiDcgASoCbBJWVmwUT");
			DualShock4Driver.NativeFieldInfoPtr_RUqxFhXZXCJwBaIXjyWYPbcseaN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "RUqxFhXZXCJwBaIXjyWYPbcseaN");
			DualShock4Driver.NativeFieldInfoPtr_RlPbGpoetcVHHVwCmAAihzjLuYH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "RlPbGpoetcVHHVwCmAAihzjLuYH");
			DualShock4Driver.NativeFieldInfoPtr_iTfwmpAIBVwcJdXQessdnwPTLpF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "iTfwmpAIBVwcJdXQessdnwPTLpF");
			DualShock4Driver.NativeFieldInfoPtr_JOdxhCEhCyFSMIzcwehPegmSkHiy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "JOdxhCEhCyFSMIzcwehPegmSkHiy");
			DualShock4Driver.NativeFieldInfoPtr_pngETfayGPvSrOjZjvqgaFZJvfc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "pngETfayGPvSrOjZjvqgaFZJvfc");
			DualShock4Driver.NativeFieldInfoPtr_YOsgilLTnUFVpjqmLEEibZdXcYRQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "YOsgilLTnUFVpjqmLEEibZdXcYRQ");
			DualShock4Driver.NativeFieldInfoPtr_DukFFNvmiLRKsyAjODjrGhQBGnL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "DukFFNvmiLRKsyAjODjrGhQBGnL");
			DualShock4Driver.NativeFieldInfoPtr_fBLvQFYipvjtlfYVBgxEMoFHCiiB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "fBLvQFYipvjtlfYVBgxEMoFHCiiB");
			DualShock4Driver.NativeFieldInfoPtr_SMoAnscTohLhkRCINmKDimcdDrha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "SMoAnscTohLhkRCINmKDimcdDrha");
			DualShock4Driver.NativeFieldInfoPtr_ewAwOWPRZrTGiLDAAiOYHtWvayr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "ewAwOWPRZrTGiLDAAiOYHtWvayr");
			DualShock4Driver.NativeFieldInfoPtr_nbksJZgjBqdspiaJiKOmAmEioaiH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "nbksJZgjBqdspiaJiKOmAmEioaiH");
			DualShock4Driver.NativeFieldInfoPtr_DugdatQgfbvfYbWbkKLDKCYLPaA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "DugdatQgfbvfYbWbkKLDKCYLPaA");
			DualShock4Driver.NativeFieldInfoPtr_DAUINcLKpAQacqmWMUIzRBtPWQi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "DAUINcLKpAQacqmWMUIzRBtPWQi");
			DualShock4Driver.NativeFieldInfoPtr_QYRvzOxFNpkSULNPpVRzHPlduSR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "QYRvzOxFNpkSULNPpVRzHPlduSR");
			DualShock4Driver.NativeFieldInfoPtr_ercldrMDMwXEPurVOaoJxnVVpls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "ercldrMDMwXEPurVOaoJxnVVpls");
			DualShock4Driver.NativeFieldInfoPtr_YPjwmLyiGMgZqaXDYTZImQRTYEO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "YPjwmLyiGMgZqaXDYTZImQRTYEO");
			DualShock4Driver.NativeFieldInfoPtr_OPYDCjKKkittUJrThlfyTQNZWEIG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "OPYDCjKKkittUJrThlfyTQNZWEIG");
			DualShock4Driver.NativeFieldInfoPtr_mjBnEAbcHYxisFdFlFoFkBglZOBn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "mjBnEAbcHYxisFdFlFoFkBglZOBn");
			DualShock4Driver.NativeFieldInfoPtr_VFDHHQcZdJhoVuZYXYHsXvpfeOL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "VFDHHQcZdJhoVuZYXYHsXvpfeOL");
			DualShock4Driver.NativeFieldInfoPtr_MXGPRGAXeZnmaeVJRhyPEaVTkXQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "MXGPRGAXeZnmaeVJRhyPEaVTkXQ");
			DualShock4Driver.NativeFieldInfoPtr_TUDBImFUfxFLWRotJFCpRJvzDZa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "TUDBImFUfxFLWRotJFCpRJvzDZa");
			DualShock4Driver.NativeFieldInfoPtr_bkfuctINqlGyShIdchJBqLCYxstJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "bkfuctINqlGyShIdchJBqLCYxstJ");
			DualShock4Driver.NativeFieldInfoPtr_ckzrduSceznhfUkVNVzAlrFMzOk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "ckzrduSceznhfUkVNVzAlrFMzOk");
			DualShock4Driver.NativeFieldInfoPtr_lXKFeRBfejoFIuuyCCeCQPgXmdAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "lXKFeRBfejoFIuuyCCeCQPgXmdAP");
			DualShock4Driver.NativeFieldInfoPtr_qDdCVvKQZbrijiZvgipubafbXOo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "qDdCVvKQZbrijiZvgipubafbXOo");
			DualShock4Driver.NativeFieldInfoPtr_LcPJePsNJDGRzaAichDdYIgnONuI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "LcPJePsNJDGRzaAichDdYIgnONuI");
			DualShock4Driver.NativeFieldInfoPtr_hbVTfeoNOpiGfjtSvuUJcKveeIPP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "hbVTfeoNOpiGfjtSvuUJcKveeIPP");
			DualShock4Driver.NativeFieldInfoPtr_fMiifxYpLKJReuIOPISvCpJbUqYi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "fMiifxYpLKJReuIOPISvCpJbUqYi");
			DualShock4Driver.NativeFieldInfoPtr_egeIAYGpUfUEQnQHRNtccoCwhkb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "egeIAYGpUfUEQnQHRNtccoCwhkb");
			DualShock4Driver.NativeFieldInfoPtr_uBCvvZAaNoajgRatNflOHdudRbrB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "uBCvvZAaNoajgRatNflOHdudRbrB");
			DualShock4Driver.NativeFieldInfoPtr_mPARfXQHiXPIiWsEdawLAmEocmM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "mPARfXQHiXPIiWsEdawLAmEocmM");
			DualShock4Driver.NativeFieldInfoPtr_tmIocfPzYqSkyWAsAqKlPqHeQyA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "tmIocfPzYqSkyWAsAqKlPqHeQyA");
			DualShock4Driver.NativeFieldInfoPtr_rWuGSHcFIrSEtLmEWnwNAAMIkTQh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "rWuGSHcFIrSEtLmEWnwNAAMIkTQh");
			DualShock4Driver.NativeFieldInfoPtr_FXCndKilsLeiQIcUSfpHzZDAPmwF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "FXCndKilsLeiQIcUSfpHzZDAPmwF");
			DualShock4Driver.NativeFieldInfoPtr_fxDKuXoXhRfNScEQSkchCEEpvBY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "fxDKuXoXhRfNScEQSkchCEEpvBY");
			DualShock4Driver.NativeFieldInfoPtr_dBoIMedCMyQNHjRaJpngjHJXfMdE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "dBoIMedCMyQNHjRaJpngjHJXfMdE");
			DualShock4Driver.NativeFieldInfoPtr_izYKmDpxFzOrqRbOivvudHllUsE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "izYKmDpxFzOrqRbOivvudHllUsE");
			DualShock4Driver.NativeFieldInfoPtr_GeDQfGevPhhOtATwmXkLyHvWccw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "GeDQfGevPhhOtATwmXkLyHvWccw");
			DualShock4Driver.NativeFieldInfoPtr_VqjireeisHBGAbOmixQcKOQABZY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "VqjireeisHBGAbOmixQcKOQABZY");
			DualShock4Driver.NativeFieldInfoPtr_SEQenGfoIoNZmaGLiQDgmYcHfBRG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "SEQenGfoIoNZmaGLiQDgmYcHfBRG");
			DualShock4Driver.NativeFieldInfoPtr_NXVqXgfUsQHbVRrEpuYEreBlzpN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "NXVqXgfUsQHbVRrEpuYEreBlzpN");
			DualShock4Driver.NativeFieldInfoPtr_dzydtpDkcOlbZPaRhVbfGNBdrDQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "dzydtpDkcOlbZPaRhVbfGNBdrDQ");
			DualShock4Driver.NativeFieldInfoPtr_MqcIIdsSwUqQdRoXaTgVghcDhrW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "MqcIIdsSwUqQdRoXaTgVghcDhrW");
			DualShock4Driver.NativeFieldInfoPtr_vXhBOHFjjsQqepcCZLmNAKpcINBV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "vXhBOHFjjsQqepcCZLmNAKpcINBV");
			DualShock4Driver.NativeFieldInfoPtr_WiKTTbpsgABuAkMhYSavFVjifRv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "WiKTTbpsgABuAkMhYSavFVjifRv");
			DualShock4Driver.NativeFieldInfoPtr_GjYzRFszhGQQgQSGrnIRVGWAJXr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "GjYzRFszhGQQgQSGrnIRVGWAJXr");
			DualShock4Driver.NativeFieldInfoPtr_vWODbbChHxjsJwFcccLzWSgbQGAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "vWODbbChHxjsJwFcccLzWSgbQGAI");
			DualShock4Driver.NativeFieldInfoPtr_XVfeDFKQSiWWjEnCYqeBmfVLANBm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "XVfeDFKQSiWWjEnCYqeBmfVLANBm");
			DualShock4Driver.NativeFieldInfoPtr_kEQdqkMxSYRqzzGPHAxtXPlPzkZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "kEQdqkMxSYRqzzGPHAxtXPlPzkZ");
			DualShock4Driver.NativeFieldInfoPtr_RTKlxLjGuZLRqfVuXrlNDhwBiTy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "RTKlxLjGuZLRqfVuXrlNDhwBiTy");
			DualShock4Driver.NativeFieldInfoPtr_ippVKLLMqIBFhRtXoenvVQntAJd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "ippVKLLMqIBFhRtXoenvVQntAJd");
			DualShock4Driver.NativeFieldInfoPtr_qjntYfLoESbAWHDBNDGxRCXJMfy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "qjntYfLoESbAWHDBNDGxRCXJMfy");
			DualShock4Driver.NativeFieldInfoPtr_XnRnoVdLhJkUOHOAQhipOOfFLpk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "XnRnoVdLhJkUOHOAQhipOOfFLpk");
			DualShock4Driver.NativeFieldInfoPtr_bUbhTMCGWaCoOqSuDMxcebgtRqzV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "bUbhTMCGWaCoOqSuDMxcebgtRqzV");
			DualShock4Driver.NativeFieldInfoPtr_OLKxRVqOsIErBUQFLStrlOJjitj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "OLKxRVqOsIErBUQFLStrlOJjitj");
			DualShock4Driver.NativeFieldInfoPtr_oHPGAxVesPYWMwkICufJHTEytZG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "oHPGAxVesPYWMwkICufJHTEytZG");
			DualShock4Driver.NativeFieldInfoPtr_nQtUtyADXujDLjRfcvigVPkcmUX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "nQtUtyADXujDLjRfcvigVPkcmUX");
			DualShock4Driver.NativeFieldInfoPtr_pmmntafFsJVEOxFZPqxaaiZpAMO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "pmmntafFsJVEOxFZPqxaaiZpAMO");
			DualShock4Driver.NativeFieldInfoPtr_aOwynHDBqdQEJSMuGFrjRNscfyAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "aOwynHDBqdQEJSMuGFrjRNscfyAD");
			DualShock4Driver.NativeFieldInfoPtr_oTQFLvxokTfPetxLSxzfnaixHvs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "oTQFLvxokTfPetxLSxzfnaixHvs");
			DualShock4Driver.NativeFieldInfoPtr_DhbhSRVhmFGIEaEXjUaEnRbxQZd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, "DhbhSRVhmFGIEaEXjUaEnRbxQZd");
			DualShock4Driver.NativeMethodInfoPtr_get_isVibrating_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669629);
			DualShock4Driver.NativeMethodInfoPtr_get_BatteryLevel_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669630);
			DualShock4Driver.NativeMethodInfoPtr_get_LeftMotor_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669631);
			DualShock4Driver.NativeMethodInfoPtr_set_LeftMotor_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669632);
			DualShock4Driver.NativeMethodInfoPtr_get_RightMotor_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669633);
			DualShock4Driver.NativeMethodInfoPtr_set_RightMotor_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669634);
			DualShock4Driver.NativeMethodInfoPtr_get_LightColorR_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669635);
			DualShock4Driver.NativeMethodInfoPtr_set_LightColorR_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669636);
			DualShock4Driver.NativeMethodInfoPtr_get_LightColorG_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669637);
			DualShock4Driver.NativeMethodInfoPtr_set_LightColorG_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669638);
			DualShock4Driver.NativeMethodInfoPtr_get_LightColorB_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669639);
			DualShock4Driver.NativeMethodInfoPtr_set_LightColorB_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669640);
			DualShock4Driver.NativeMethodInfoPtr_get_LightFlashOnDuration_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669641);
			DualShock4Driver.NativeMethodInfoPtr_set_LightFlashOnDuration_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669642);
			DualShock4Driver.NativeMethodInfoPtr_get_LightFlashOffDuration_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669643);
			DualShock4Driver.NativeMethodInfoPtr_set_LightFlashOffDuration_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669644);
			DualShock4Driver.NativeMethodInfoPtr_get_AccelerometerValue_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669645);
			DualShock4Driver.NativeMethodInfoPtr_get_AccelerometerValueRaw_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669646);
			DualShock4Driver.NativeMethodInfoPtr_get_GyroscopeValue_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669647);
			DualShock4Driver.NativeMethodInfoPtr_get_GyroscopeValueRaw_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669648);
			DualShock4Driver.NativeMethodInfoPtr_get_LastGyroscopeValue_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669649);
			DualShock4Driver.NativeMethodInfoPtr_get_LastGyroscopeValueRaw_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669650);
			DualShock4Driver.NativeMethodInfoPtr_get_Orientation_Public_Virtual_Final_New_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669651);
			DualShock4Driver.NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669652);
			DualShock4Driver.NativeMethodInfoPtr_get_MaxTouches_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669653);
			DualShock4Driver.NativeMethodInfoPtr_GetTouchCount_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669654);
			DualShock4Driver.NativeMethodInfoPtr_IsTouchingAtIndex_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669655);
			DualShock4Driver.NativeMethodInfoPtr_IsTouchingAtTouchId_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669656);
			DualShock4Driver.NativeMethodInfoPtr_GetTouchIdAtIndex_Public_Virtual_Final_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669657);
			DualShock4Driver.NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669658);
			DualShock4Driver.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669659);
			DualShock4Driver.NativeMethodInfoPtr_GetTouchPositionAbsoluteByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669660);
			DualShock4Driver.NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669661);
			DualShock4Driver.NativeMethodInfoPtr_StopLightFlash_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669662);
			DualShock4Driver.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669663);
			DualShock4Driver.NativeMethodInfoPtr__ctor_Public_Void_InitArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669664);
			DualShock4Driver.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669665);
			DualShock4Driver.NativeMethodInfoPtr_ParseInputReport_Public_Virtual_Boolean_IntPtr_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669666);
			DualShock4Driver.NativeMethodInfoPtr_CreateControllerExtension_Public_Virtual_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669667);
			DualShock4Driver.NativeMethodInfoPtr_TSrVJoovajrfJhhpgPSTUJfwLdn_Private_Void_rBapAxSjeCWOiOHyzennMIRNCHfj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669668);
			DualShock4Driver.NativeMethodInfoPtr_zNXomrMcpdzggtTitEdjWdzqgEbj_Private_Boolean_rBapAxSjeCWOiOHyzennMIRNCHfj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669669);
			DualShock4Driver.NativeMethodInfoPtr_IuZFpZfntxLYutBfTAuqVYKxfjj_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669670);
			DualShock4Driver.NativeMethodInfoPtr_bWlObuwhPuWKIEdjMaLCkLFuAubl_Private_Boolean_rBapAxSjeCWOiOHyzennMIRNCHfj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669671);
			DualShock4Driver.NativeMethodInfoPtr_QLZdJmwnUkddZisUnLmixtMACSh_Private_Void_NativeBuffer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669672);
			DualShock4Driver.NativeMethodInfoPtr_gbHdOZilzwmhPaLsoSTdCfNBZKKu_Private_Void_Il2CppReferenceArray_1_HIDControllerElement_NativeBuffer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669673);
			DualShock4Driver.NativeMethodInfoPtr_KHqFCPtEwwtfLgFTiAQgQrcOjjb_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669674);
			DualShock4Driver.NativeMethodInfoPtr_LeplGUzBFQKWBFpGxiDontkepOK_Private_Void_NativeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669675);
			DualShock4Driver.NativeMethodInfoPtr_TLwGAPVnufqvIFbiUtPrqoyNGkr_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669676);
			DualShock4Driver.NativeMethodInfoPtr_cohbXzjxzOcNAeSeyhxjbfXCJFQ_Private_Static_Boolean_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669677);
			DualShock4Driver.NativeMethodInfoPtr_OeYAIeGFRPZFIOSRbUgsokmVUlq_Private_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669678);
			DualShock4Driver.NativeMethodInfoPtr_vZfQKBwCEWApahARXbtasPYbHzZ_Private_Static_Quaternion_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669679);
			DualShock4Driver.NativeMethodInfoPtr_HNzAAnmQWRfPwDoAHmOVRTmQhjHg_Private_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669680);
			DualShock4Driver.NativeMethodInfoPtr_thTaDDdinQFebglkGeuCSsdQcuKj_Private_Quaternion_Quaternion_jzVxvhtsjKltyydiJeoxkueAqME_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669681);
			DualShock4Driver.NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669682);
			DualShock4Driver.NativeMethodInfoPtr_TLAawbbzgTTOntVMVRSOYGgBlSz_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669683);
			DualShock4Driver.NativeMethodInfoPtr_TgJSJBfkacluENeCrcEMrjyCzZk_Private_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669684);
			DualShock4Driver.NativeMethodInfoPtr_EVPzweUACCpCpHpeeEMnGnyiGub_Private_Quaternion_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669685);
			DualShock4Driver.NativeMethodInfoPtr_FTcGFQGKepOCGivEwiXcIfpiwzo_Private_Quaternion_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669686);
			DualShock4Driver.NativeMethodInfoPtr_fQsbUcErhAOleloWxhSUBrwCiPqT_Private_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669687);
			DualShock4Driver.NativeMethodInfoPtr_ekTnVhTROxwNIqHvokaYcuOYwut_Private_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669688);
			DualShock4Driver.NativeMethodInfoPtr_robusEWPfTfHCeHSBdccMSzDezZ_Private_Boolean_Vector3_byref_vusGPPHdFNxUjCOgdVnBzVBgWSV_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669689);
			DualShock4Driver.NativeMethodInfoPtr_DIkDxlDsItuOVMlNgZuHlQvMhaFQ_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669690);
			DualShock4Driver.NativeMethodInfoPtr_uaWAYcACiSsMWDcNpMnjBRRdSgR_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669691);
			DualShock4Driver.NativeMethodInfoPtr_DtptwGvMHHWYtiObmjGUBSGKWWS_Private_Vector3_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669692);
			DualShock4Driver.NativeMethodInfoPtr_ThbIRbwHDVgOvNnDNaPNIFyStTC_Private_Vector3_ExpandableArray_DataContainer_1_vwnDNljqUPuTIauvXLOcbBHPCtP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669693);
			DualShock4Driver.NativeMethodInfoPtr_ThbIRbwHDVgOvNnDNaPNIFyStTC_Private_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669694);
			DualShock4Driver.NativeMethodInfoPtr_SAHHnzXBzBbRKuuXiURZugBrZSC_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669695);
			DualShock4Driver.NativeMethodInfoPtr_jouvWBjeMlbfGjdhJNLFnQsLdBOb_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669696);
			DualShock4Driver.NativeMethodInfoPtr_prYGimAxzhhkgHXVHtncfHnGFYY_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669697);
			DualShock4Driver.NativeMethodInfoPtr_qeFMJjnMLTATARRnrcCxoPuiWfW_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669698);
			DualShock4Driver.NativeMethodInfoPtr_nQkXLniZUrHBOFIEofKzaOcIykH_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669699);
			DualShock4Driver.NativeMethodInfoPtr_sDEBJHxzkRveoJulMncayCApMQt_Private_Void_NativeBuffer_Il2CppStructArray_1_TouchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669700);
			DualShock4Driver.NativeMethodInfoPtr_okliethpUEesGZsNxgsPNrXkCiZ_Private_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669701);
			DualShock4Driver.NativeMethodInfoPtr_dGrqytUXXWkxJliqQJXVhZPBxBd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669702);
			DualShock4Driver.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669703);
			DualShock4Driver.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669704);
			DualShock4Driver.NativeMethodInfoPtr_Matches_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr, 100669705);
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x00098974 File Offset: 0x00096B74
		public unsafe bool isVibrating
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_isVibrating_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x000989B0 File Offset: 0x00096BB0
		public unsafe virtual float BatteryLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279763, XrefRangeEnd = 279764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_BatteryLevel_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x000989EC File Offset: 0x00096BEC
		// (set) Token: 0x06001BD3 RID: 7123 RVA: 0x00098A28 File Offset: 0x00096C28
		public unsafe virtual float LeftMotor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_LeftMotor_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_set_LeftMotor_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x00098A68 File Offset: 0x00096C68
		// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x00098AA4 File Offset: 0x00096CA4
		public unsafe virtual float RightMotor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_RightMotor_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_set_RightMotor_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x00098AE4 File Offset: 0x00096CE4
		// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x00098B20 File Offset: 0x00096D20
		public unsafe virtual float LightColorR
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_LightColorR_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_set_LightColorR_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x00098B60 File Offset: 0x00096D60
		// (set) Token: 0x06001BD9 RID: 7129 RVA: 0x00098B9C File Offset: 0x00096D9C
		public unsafe virtual float LightColorG
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_LightColorG_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_set_LightColorG_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x00098BDC File Offset: 0x00096DDC
		// (set) Token: 0x06001BDB RID: 7131 RVA: 0x00098C18 File Offset: 0x00096E18
		public unsafe virtual float LightColorB
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_LightColorB_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_set_LightColorB_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001BDC RID: 7132 RVA: 0x00098C58 File Offset: 0x00096E58
		// (set) Token: 0x06001BDD RID: 7133 RVA: 0x00098C94 File Offset: 0x00096E94
		public unsafe virtual float LightFlashOnDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_LightFlashOnDuration_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279764, XrefRangeEnd = 279765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_set_LightFlashOnDuration_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x00098CD4 File Offset: 0x00096ED4
		// (set) Token: 0x06001BDF RID: 7135 RVA: 0x00098D10 File Offset: 0x00096F10
		public unsafe virtual float LightFlashOffDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_LightFlashOffDuration_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279765, XrefRangeEnd = 279767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_set_LightFlashOffDuration_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x00098D50 File Offset: 0x00096F50
		public unsafe virtual Vector3 AccelerometerValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_AccelerometerValue_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x00098D8C File Offset: 0x00096F8C
		public unsafe virtual Vector3 AccelerometerValueRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_AccelerometerValueRaw_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x00098DC8 File Offset: 0x00096FC8
		public unsafe virtual Vector3 GyroscopeValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279767, XrefRangeEnd = 279770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_GyroscopeValue_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x00098E04 File Offset: 0x00097004
		public unsafe virtual Vector3 GyroscopeValueRaw
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_GyroscopeValueRaw_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x00098E40 File Offset: 0x00097040
		public unsafe virtual Vector3 LastGyroscopeValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_LastGyroscopeValue_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x00098E7C File Offset: 0x0009707C
		public unsafe virtual Vector3 LastGyroscopeValueRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_LastGyroscopeValueRaw_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x00098EB8 File Offset: 0x000970B8
		public unsafe virtual Quaternion Orientation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_Orientation_Public_Virtual_Final_New_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x00098EF4 File Offset: 0x000970F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279770, XrefRangeEnd = 279772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x00098F28 File Offset: 0x00097128
		public unsafe virtual int MaxTouches
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_get_MaxTouches_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x00098F64 File Offset: 0x00097164
		[CallerCount(0)]
		public unsafe virtual int GetTouchCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_GetTouchCount_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x00098FA0 File Offset: 0x000971A0
		[CallerCount(0)]
		public unsafe virtual bool IsTouchingAtIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_IsTouchingAtIndex_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00098FEC File Offset: 0x000971EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsTouchingAtTouchId(int touchId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_IsTouchingAtTouchId_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00099038 File Offset: 0x00097238
		[CallerCount(0)]
		public unsafe virtual int GetTouchIdAtIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_GetTouchIdAtIndex_Public_Virtual_Final_New_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00099084 File Offset: 0x00097284
		[CallerCount(0)]
		public unsafe virtual bool GetTouchPositionByIndex(int index, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x000990DC File Offset: 0x000972DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetTouchPositionByTouchId(int touchId, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00099134 File Offset: 0x00097334
		[CallerCount(0)]
		public unsafe virtual bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &positionX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &positionY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_GetTouchPositionAbsoluteByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x0009919C File Offset: 0x0009739C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &positionX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &positionY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00099204 File Offset: 0x00097404
		[CallerCount(0)]
		public unsafe virtual void StopLightFlash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_StopLightFlash_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00099238 File Offset: 0x00097438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopVibration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0009926C File Offset: 0x0009746C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279772, XrefRangeEnd = 279996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DualShock4Driver(HIDDeviceDriver.InitArgs initArgs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualShock4Driver>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initArgs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr__ctor_Public_Void_InitArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x000992B8 File Offset: 0x000974B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279996, XrefRangeEnd = 280005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualShock4Driver.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00099304 File Offset: 0x00097504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280005, XrefRangeEnd = 280022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputReportPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputReportLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timestamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualShock4Driver.NativeMethodInfoPtr_ParseInputReport_Public_Virtual_Boolean_IntPtr_Int32_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00099374 File Offset: 0x00097574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280022, XrefRangeEnd = 280026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Controller.Extension CreateControllerExtension()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualShock4Driver.NativeMethodInfoPtr_CreateControllerExtension_Public_Virtual_Extension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x000993C0 File Offset: 0x000975C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280029, RefRangeEnd = 280030, XrefRangeStart = 280026, XrefRangeEnd = 280029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TSrVJoovajrfJhhpgPSTUJfwLdn(rBapAxSjeCWOiOHyzennMIRNCHfj A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_TSrVJoovajrfJhhpgPSTUJfwLdn_Private_Void_rBapAxSjeCWOiOHyzennMIRNCHfj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00099400 File Offset: 0x00097600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280030, XrefRangeEnd = 280033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool zNXomrMcpdzggtTitEdjWdzqgEbj(rBapAxSjeCWOiOHyzennMIRNCHfj A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_zNXomrMcpdzggtTitEdjWdzqgEbj_Private_Boolean_rBapAxSjeCWOiOHyzennMIRNCHfj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0009944C File Offset: 0x0009764C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 280081, RefRangeEnd = 280086, XrefRangeStart = 280033, XrefRangeEnd = 280081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IuZFpZfntxLYutBfTAuqVYKxfjj()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_IuZFpZfntxLYutBfTAuqVYKxfjj_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00099480 File Offset: 0x00097680
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 280094, RefRangeEnd = 280104, XrefRangeStart = 280086, XrefRangeEnd = 280094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool bWlObuwhPuWKIEdjMaLCkLFuAubl(rBapAxSjeCWOiOHyzennMIRNCHfj A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_bWlObuwhPuWKIEdjMaLCkLFuAubl_Private_Boolean_rBapAxSjeCWOiOHyzennMIRNCHfj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x000994CC File Offset: 0x000976CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280107, RefRangeEnd = 280108, XrefRangeStart = 280104, XrefRangeEnd = 280107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QLZdJmwnUkddZisUnLmixtMACSh(NativeBuffer A_1, double A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_QLZdJmwnUkddZisUnLmixtMACSh_Private_Void_NativeBuffer_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0009951C File Offset: 0x0009771C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void gbHdOZilzwmhPaLsoSTdCfNBZKKu(Il2CppReferenceArray<HIDControllerElement> A_1, NativeBuffer A_2, double A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_gbHdOZilzwmhPaLsoSTdCfNBZKKu_Private_Void_Il2CppReferenceArray_1_HIDControllerElement_NativeBuffer_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00099580 File Offset: 0x00097780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280108, XrefRangeEnd = 280114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KHqFCPtEwwtfLgFTiAQgQrcOjjb()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_KHqFCPtEwwtfLgFTiAQgQrcOjjb_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x000995B4 File Offset: 0x000977B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280114, XrefRangeEnd = 280120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeplGUzBFQKWBFpGxiDontkepOK(NativeBuffer A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_LeplGUzBFQKWBFpGxiDontkepOK_Private_Void_NativeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x000995F8 File Offset: 0x000977F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280122, RefRangeEnd = 280123, XrefRangeStart = 280120, XrefRangeEnd = 280122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TLwGAPVnufqvIFbiUtPrqoyNGkr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_TLwGAPVnufqvIFbiUtPrqoyNGkr_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0009962C File Offset: 0x0009782C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool cohbXzjxzOcNAeSeyhxjbfXCJFQ(ref Vector3 A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_cohbXzjxzOcNAeSeyhxjbfXCJFQ_Private_Static_Boolean_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0009966C File Offset: 0x0009786C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280164, RefRangeEnd = 280165, XrefRangeStart = 280123, XrefRangeEnd = 280164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OeYAIeGFRPZFIOSRbUgsokmVUlq(Vector3 A_1, Vector3 A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_OeYAIeGFRPZFIOSRbUgsokmVUlq_Private_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x000996B8 File Offset: 0x000978B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280165, XrefRangeEnd = 280168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion vZfQKBwCEWApahARXbtasPYbHzZ(Quaternion A_0, Vector3 A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_vZfQKBwCEWApahARXbtasPYbHzZ_Private_Static_Quaternion_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00099704 File Offset: 0x00097904
		[CallerCount(0)]
		public unsafe static Vector3 HNzAAnmQWRfPwDoAHmOVRTmQhjHg(Vector3 A_0, Vector3 A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_HNzAAnmQWRfPwDoAHmOVRTmQhjHg_Private_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00099750 File Offset: 0x00097950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion thTaDDdinQFebglkGeuCSsdQcuKj(Quaternion A_1, DualShock4Driver.jzVxvhtsjKltyydiJeoxkueAqME A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_thTaDDdinQFebglkGeuCSsdQcuKj_Private_Quaternion_Quaternion_jzVxvhtsjKltyydiJeoxkueAqME_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x000997A8 File Offset: 0x000979A8
		[CallerCount(0)]
		public unsafe static Quaternion Inverse(Quaternion quaternion)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref quaternion;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x000997E8 File Offset: 0x000979E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float TLAawbbzgTTOntVMVRSOYGgBlSz(float A_1, float A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_TLAawbbzgTTOntVMVRSOYGgBlSz_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00099840 File Offset: 0x00097A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TgJSJBfkacluENeCrcEMrjyCzZk(Vector3 A_1, float A_2 = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_TgJSJBfkacluENeCrcEMrjyCzZk_Private_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00099898 File Offset: 0x00097A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion EVPzweUACCpCpHpeeEMnGnyiGub(Vector3 A_1, float A_2 = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_EVPzweUACCpCpHpeeEMnGnyiGub_Private_Quaternion_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x000998F0 File Offset: 0x00097AF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279710, RefRangeEnd = 279712, XrefRangeStart = 279710, XrefRangeEnd = 279712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion FTcGFQGKepOCGivEwiXcIfpiwzo(Vector3 A_1, float A_2 = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_FTcGFQGKepOCGivEwiXcIfpiwzo_Private_Quaternion_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00099948 File Offset: 0x00097B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float fQsbUcErhAOleloWxhSUBrwCiPqT(Vector3 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_fQsbUcErhAOleloWxhSUBrwCiPqT_Private_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00099994 File Offset: 0x00097B94
		[CallerCount(0)]
		public unsafe bool ekTnVhTROxwNIqHvokaYcuOYwut(float A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_ekTnVhTROxwNIqHvokaYcuOYwut_Private_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x000999E0 File Offset: 0x00097BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool robusEWPfTfHCeHSBdccMSzDezZ(Vector3 A_1, out DualShock4Driver.vusGPPHdFNxUjCOgdVnBzVBgWSV A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_robusEWPfTfHCeHSBdccMSzDezZ_Private_Boolean_Vector3_byref_vusGPPHdFNxUjCOgdVnBzVBgWSV_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00099A38 File Offset: 0x00097C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DIkDxlDsItuOVMlNgZuHlQvMhaFQ(Vector3 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_DIkDxlDsItuOVMlNgZuHlQvMhaFQ_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00099A84 File Offset: 0x00097C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool uaWAYcACiSsMWDcNpMnjBRRdSgR(Vector3 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_uaWAYcACiSsMWDcNpMnjBRRdSgR_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00099AD0 File Offset: 0x00097CD0
		[CallerCount(0)]
		public unsafe Vector3 DtptwGvMHHWYtiObmjGUBSGKWWS(Il2CppStructArray<float> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_DtptwGvMHHWYtiObmjGUBSGKWWS_Private_Vector3_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00099B20 File Offset: 0x00097D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280168, XrefRangeEnd = 280170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ThbIRbwHDVgOvNnDNaPNIFyStTC(ExpandableArray_DataContainer<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_ThbIRbwHDVgOvNnDNaPNIFyStTC_Private_Vector3_ExpandableArray_DataContainer_1_vwnDNljqUPuTIauvXLOcbBHPCtP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00099B70 File Offset: 0x00097D70
		[CallerCount(0)]
		public unsafe Vector3 ThbIRbwHDVgOvNnDNaPNIFyStTC(Vector3 A_1, float A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_ThbIRbwHDVgOvNnDNaPNIFyStTC_Private_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x00099BC8 File Offset: 0x00097DC8
		[CallerCount(0)]
		public unsafe Vector3 SAHHnzXBzBbRKuuXiURZugBrZSC(Vector3 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_SAHHnzXBzBbRKuuXiURZugBrZSC_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x00099C14 File Offset: 0x00097E14
		[CallerCount(0)]
		public unsafe int jouvWBjeMlbfGjdhJNLFnQsLdBOb(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_jouvWBjeMlbfGjdhJNLFnQsLdBOb_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x00099C60 File Offset: 0x00097E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280170, XrefRangeEnd = 280176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void prYGimAxzhhkgHXVHtncfHnGFYY(Il2CppStructArray<byte> A_1, Il2CppStructArray<float> A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_prYGimAxzhhkgHXVHtncfHnGFYY_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x00099CB4 File Offset: 0x00097EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280176, XrefRangeEnd = 280182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void qeFMJjnMLTATARRnrcCxoPuiWfW(Il2CppStructArray<byte> A_1, Il2CppStructArray<float> A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_qeFMJjnMLTATARRnrcCxoPuiWfW_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x00099D08 File Offset: 0x00097F08
		[CallerCount(0)]
		public unsafe float nQkXLniZUrHBOFIEofKzaOcIykH()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_nQkXLniZUrHBOFIEofKzaOcIykH_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x00099D44 File Offset: 0x00097F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280182, XrefRangeEnd = 280194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void sDEBJHxzkRveoJulMncayCApMQt(NativeBuffer A_1, Il2CppStructArray<HIDTouchpad.TouchData> A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_sDEBJHxzkRveoJulMncayCApMQt_Private_Void_NativeBuffer_Il2CppStructArray_1_TouchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x00099D98 File Offset: 0x00097F98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280194, RefRangeEnd = 280196, XrefRangeStart = 280194, XrefRangeEnd = 280194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int okliethpUEesGZsNxgsPNrXkCiZ(int A_1, bool A_2, int A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_okliethpUEesGZsNxgsPNrXkCiZ_Private_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00099E00 File Offset: 0x00098000
		[CallerCount(0)]
		public unsafe void dGrqytUXXWkxJliqQJXVhZPBxBd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_dGrqytUXXWkxJliqQJXVhZPBxBd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x00099E34 File Offset: 0x00098034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualShock4Driver.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00099E70 File Offset: 0x00098070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280196, XrefRangeEnd = 280200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualShock4Driver.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x00099EBC File Offset: 0x000980BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280200, XrefRangeEnd = 280219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Matches(int vid, int pid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4Driver.NativeMethodInfoPtr_Matches_Public_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0000B724 File Offset: 0x00009924
		public DualShock4Driver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x00099F08 File Offset: 0x00098108
		// (set) Token: 0x06001C1F RID: 7199 RVA: 0x0000B72D File Offset: 0x0000992D
		public unsafe static float cBswOuBTFJaQmJaEsTSUwghjEsxb
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_cBswOuBTFJaQmJaEsTSUwghjEsxb, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_cBswOuBTFJaQmJaEsTSUwghjEsxb, (void*)(&value));
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x00099F24 File Offset: 0x00098124
		// (set) Token: 0x06001C21 RID: 7201 RVA: 0x0000B73B File Offset: 0x0000993B
		public unsafe static int XQHSiIMpmpLQwAfijbkQiqJbUVm
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&value));
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x00099F40 File Offset: 0x00098140
		// (set) Token: 0x06001C23 RID: 7203 RVA: 0x0000B749 File Offset: 0x00009949
		public unsafe static int ZSAekMXsJdpwJeuHzaalTvrqTXZ
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_ZSAekMXsJdpwJeuHzaalTvrqTXZ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_ZSAekMXsJdpwJeuHzaalTvrqTXZ, (void*)(&value));
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00099F5C File Offset: 0x0009815C
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x0000B757 File Offset: 0x00009957
		public unsafe static int xQFBlnjHmSMxSYBxUcplNCrUIpHy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_xQFBlnjHmSMxSYBxUcplNCrUIpHy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_xQFBlnjHmSMxSYBxUcplNCrUIpHy, (void*)(&value));
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00099F78 File Offset: 0x00098178
		// (set) Token: 0x06001C27 RID: 7207 RVA: 0x0000B765 File Offset: 0x00009965
		public unsafe static int DXQOduZMAdakgKHULREouGGIMsj
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_DXQOduZMAdakgKHULREouGGIMsj, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_DXQOduZMAdakgKHULREouGGIMsj, (void*)(&value));
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00099F94 File Offset: 0x00098194
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x0000B773 File Offset: 0x00009973
		public unsafe static int jkpagfZjLjeageiKHUvdcGIBUyjQ
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_jkpagfZjLjeageiKHUvdcGIBUyjQ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_jkpagfZjLjeageiKHUvdcGIBUyjQ, (void*)(&value));
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00099FB0 File Offset: 0x000981B0
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x0000B781 File Offset: 0x00009981
		public unsafe static int CbvTpyUAreHQTqRwrRyHFkkvRu
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_CbvTpyUAreHQTqRwrRyHFkkvRu, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_CbvTpyUAreHQTqRwrRyHFkkvRu, (void*)(&value));
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00099FCC File Offset: 0x000981CC
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x0000B78F File Offset: 0x0000998F
		public unsafe static bool qkfbSOvdxzFTGQsCjAxNayadEWhk
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_qkfbSOvdxzFTGQsCjAxNayadEWhk, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_qkfbSOvdxzFTGQsCjAxNayadEWhk, (void*)(&value));
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00099FE8 File Offset: 0x000981E8
		// (set) Token: 0x06001C2F RID: 7215 RVA: 0x0000B79D File Offset: 0x0000999D
		public unsafe static bool sstgLgFYucqXUgQCuJWZzpHiirhL
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_sstgLgFYucqXUgQCuJWZzpHiirhL, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_sstgLgFYucqXUgQCuJWZzpHiirhL, (void*)(&value));
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x0009A004 File Offset: 0x00098204
		// (set) Token: 0x06001C31 RID: 7217 RVA: 0x0000B7AB File Offset: 0x000099AB
		public unsafe static float AHJqxkYPMecTbQnOZRgFvJYDGTg
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_AHJqxkYPMecTbQnOZRgFvJYDGTg, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_AHJqxkYPMecTbQnOZRgFvJYDGTg, (void*)(&value));
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x0009A020 File Offset: 0x00098220
		// (set) Token: 0x06001C33 RID: 7219 RVA: 0x0000B7B9 File Offset: 0x000099B9
		public unsafe static int ykFUEgafLAgAceDkWcqiMSzQgGhj
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_ykFUEgafLAgAceDkWcqiMSzQgGhj, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_ykFUEgafLAgAceDkWcqiMSzQgGhj, (void*)(&value));
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x0009A03C File Offset: 0x0009823C
		// (set) Token: 0x06001C35 RID: 7221 RVA: 0x0000B7C7 File Offset: 0x000099C7
		public unsafe static int ucCwnEJshdgPokipDfKZUPXVGns
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_ucCwnEJshdgPokipDfKZUPXVGns, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_ucCwnEJshdgPokipDfKZUPXVGns, (void*)(&value));
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x0009A058 File Offset: 0x00098258
		// (set) Token: 0x06001C37 RID: 7223 RVA: 0x0000B7D5 File Offset: 0x000099D5
		public unsafe static int HQywWIGQbJvUyoAzHWTXqleTChs
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_HQywWIGQbJvUyoAzHWTXqleTChs, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_HQywWIGQbJvUyoAzHWTXqleTChs, (void*)(&value));
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x0009A074 File Offset: 0x00098274
		// (set) Token: 0x06001C39 RID: 7225 RVA: 0x0000B7E3 File Offset: 0x000099E3
		public unsafe static int cHNhpgkLYTObmpHxVWxLGMeDyrl
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_cHNhpgkLYTObmpHxVWxLGMeDyrl, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_cHNhpgkLYTObmpHxVWxLGMeDyrl, (void*)(&value));
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x0009A090 File Offset: 0x00098290
		// (set) Token: 0x06001C3B RID: 7227 RVA: 0x0000B7F1 File Offset: 0x000099F1
		public unsafe static int iZucelPQVvvGHDiPkrqCheppWEb
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_iZucelPQVvvGHDiPkrqCheppWEb, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_iZucelPQVvvGHDiPkrqCheppWEb, (void*)(&value));
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x0009A0AC File Offset: 0x000982AC
		// (set) Token: 0x06001C3D RID: 7229 RVA: 0x0000B7FF File Offset: 0x000099FF
		public unsafe static int uxwENVeAtCyNlYtYwbcddIUTAOou
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_uxwENVeAtCyNlYtYwbcddIUTAOou, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_uxwENVeAtCyNlYtYwbcddIUTAOou, (void*)(&value));
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x0009A0C8 File Offset: 0x000982C8
		// (set) Token: 0x06001C3F RID: 7231 RVA: 0x0000B80D File Offset: 0x00009A0D
		public unsafe static int LgKeAUHCkufZaobBGjJCDaKYadH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_LgKeAUHCkufZaobBGjJCDaKYadH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_LgKeAUHCkufZaobBGjJCDaKYadH, (void*)(&value));
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x0009A0E4 File Offset: 0x000982E4
		// (set) Token: 0x06001C41 RID: 7233 RVA: 0x0000B81B File Offset: 0x00009A1B
		public unsafe static int rTYGvTGnYfwSgAKaOlRpiyzYrWS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_rTYGvTGnYfwSgAKaOlRpiyzYrWS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_rTYGvTGnYfwSgAKaOlRpiyzYrWS, (void*)(&value));
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x0009A100 File Offset: 0x00098300
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x0000B829 File Offset: 0x00009A29
		public unsafe static int FXtDWUVkUWyrNZDVfPmoAYzjdSk
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_FXtDWUVkUWyrNZDVfPmoAYzjdSk, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_FXtDWUVkUWyrNZDVfPmoAYzjdSk, (void*)(&value));
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x0009A11C File Offset: 0x0009831C
		// (set) Token: 0x06001C45 RID: 7237 RVA: 0x0000B837 File Offset: 0x00009A37
		public unsafe static int wHEacDZJRphkGPCiPiOJlnwszcO
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_wHEacDZJRphkGPCiPiOJlnwszcO, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_wHEacDZJRphkGPCiPiOJlnwszcO, (void*)(&value));
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x0009A138 File Offset: 0x00098338
		// (set) Token: 0x06001C47 RID: 7239 RVA: 0x0000B845 File Offset: 0x00009A45
		public unsafe static int KbJfnNWgRWWhYQPqfyOdakWTCzV
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_KbJfnNWgRWWhYQPqfyOdakWTCzV, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_KbJfnNWgRWWhYQPqfyOdakWTCzV, (void*)(&value));
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x0009A154 File Offset: 0x00098354
		// (set) Token: 0x06001C49 RID: 7241 RVA: 0x0000B853 File Offset: 0x00009A53
		public unsafe static int GxwuqUBQlXZIYUGIfFZXGWQpDaP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_GxwuqUBQlXZIYUGIfFZXGWQpDaP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_GxwuqUBQlXZIYUGIfFZXGWQpDaP, (void*)(&value));
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x0009A170 File Offset: 0x00098370
		// (set) Token: 0x06001C4B RID: 7243 RVA: 0x0000B861 File Offset: 0x00009A61
		public unsafe static int hcBaVJxFQfmUjEoteGSzULttyVK
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_hcBaVJxFQfmUjEoteGSzULttyVK, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_hcBaVJxFQfmUjEoteGSzULttyVK, (void*)(&value));
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x0009A18C File Offset: 0x0009838C
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x0000B86F File Offset: 0x00009A6F
		public unsafe static int CCVbhVJfxwwdDigIhqkdBPtgRraU
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_CCVbhVJfxwwdDigIhqkdBPtgRraU, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_CCVbhVJfxwwdDigIhqkdBPtgRraU, (void*)(&value));
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x0009A1A8 File Offset: 0x000983A8
		// (set) Token: 0x06001C4F RID: 7247 RVA: 0x0000B87D File Offset: 0x00009A7D
		public unsafe static int BBxhpfDMNTIyFeBupCZIVerwBWD
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_BBxhpfDMNTIyFeBupCZIVerwBWD, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_BBxhpfDMNTIyFeBupCZIVerwBWD, (void*)(&value));
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x0009A1C4 File Offset: 0x000983C4
		// (set) Token: 0x06001C51 RID: 7249 RVA: 0x0000B88B File Offset: 0x00009A8B
		public unsafe static int DjKakIgesLnAHNafOLmjWaZijsjK
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_DjKakIgesLnAHNafOLmjWaZijsjK, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_DjKakIgesLnAHNafOLmjWaZijsjK, (void*)(&value));
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x0009A1E0 File Offset: 0x000983E0
		// (set) Token: 0x06001C53 RID: 7251 RVA: 0x0000B899 File Offset: 0x00009A99
		public unsafe static int foWgjLXVSVMFiWVEEVhFNgtUENi
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_foWgjLXVSVMFiWVEEVhFNgtUENi, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_foWgjLXVSVMFiWVEEVhFNgtUENi, (void*)(&value));
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x0009A1FC File Offset: 0x000983FC
		// (set) Token: 0x06001C55 RID: 7253 RVA: 0x0000B8A7 File Offset: 0x00009AA7
		public unsafe static int yNXkfmYzMlAdJuzyPdItIntpuRG
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_yNXkfmYzMlAdJuzyPdItIntpuRG, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_yNXkfmYzMlAdJuzyPdItIntpuRG, (void*)(&value));
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x0009A218 File Offset: 0x00098418
		// (set) Token: 0x06001C57 RID: 7255 RVA: 0x0000B8B5 File Offset: 0x00009AB5
		public unsafe static int izvXmSrSPbVoCbIocjuxlbdJFKp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_izvXmSrSPbVoCbIocjuxlbdJFKp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_izvXmSrSPbVoCbIocjuxlbdJFKp, (void*)(&value));
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x0009A234 File Offset: 0x00098434
		// (set) Token: 0x06001C59 RID: 7257 RVA: 0x0000B8C3 File Offset: 0x00009AC3
		public unsafe static int geesShSZbWMRDQXWdWhQsuPIYbg
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_geesShSZbWMRDQXWdWhQsuPIYbg, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_geesShSZbWMRDQXWdWhQsuPIYbg, (void*)(&value));
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x0009A250 File Offset: 0x00098450
		// (set) Token: 0x06001C5B RID: 7259 RVA: 0x0000B8D1 File Offset: 0x00009AD1
		public unsafe static int EsFJPdDRcznZMMLQtKTzZswcLZN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_EsFJPdDRcznZMMLQtKTzZswcLZN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_EsFJPdDRcznZMMLQtKTzZswcLZN, (void*)(&value));
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x0009A26C File Offset: 0x0009846C
		// (set) Token: 0x06001C5D RID: 7261 RVA: 0x0000B8DF File Offset: 0x00009ADF
		public unsafe static int DfBydhNWOOkPYugrHJaqMYmzYxW
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_DfBydhNWOOkPYugrHJaqMYmzYxW, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_DfBydhNWOOkPYugrHJaqMYmzYxW, (void*)(&value));
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x0009A288 File Offset: 0x00098488
		// (set) Token: 0x06001C5F RID: 7263 RVA: 0x0000B8ED File Offset: 0x00009AED
		public unsafe static int axsAWDoBfYTvKuiIBVCENVMNClI
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_axsAWDoBfYTvKuiIBVCENVMNClI, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_axsAWDoBfYTvKuiIBVCENVMNClI, (void*)(&value));
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x0009A2A4 File Offset: 0x000984A4
		// (set) Token: 0x06001C61 RID: 7265 RVA: 0x0000B8FB File Offset: 0x00009AFB
		public unsafe static int RkmXSIwacUHALbRdEDzDbXwbiNm
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_RkmXSIwacUHALbRdEDzDbXwbiNm, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_RkmXSIwacUHALbRdEDzDbXwbiNm, (void*)(&value));
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x0009A2C0 File Offset: 0x000984C0
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x0000B909 File Offset: 0x00009B09
		public unsafe static int zNJxXdOIpKiDcgASoCbBJWVmwUT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_zNJxXdOIpKiDcgASoCbBJWVmwUT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_zNJxXdOIpKiDcgASoCbBJWVmwUT, (void*)(&value));
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x0009A2DC File Offset: 0x000984DC
		// (set) Token: 0x06001C65 RID: 7269 RVA: 0x0000B917 File Offset: 0x00009B17
		public unsafe static int RUqxFhXZXCJwBaIXjyWYPbcseaN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_RUqxFhXZXCJwBaIXjyWYPbcseaN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_RUqxFhXZXCJwBaIXjyWYPbcseaN, (void*)(&value));
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x0009A2F8 File Offset: 0x000984F8
		// (set) Token: 0x06001C67 RID: 7271 RVA: 0x0000B925 File Offset: 0x00009B25
		public unsafe static int RlPbGpoetcVHHVwCmAAihzjLuYH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_RlPbGpoetcVHHVwCmAAihzjLuYH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_RlPbGpoetcVHHVwCmAAihzjLuYH, (void*)(&value));
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x0009A314 File Offset: 0x00098514
		// (set) Token: 0x06001C69 RID: 7273 RVA: 0x0000B933 File Offset: 0x00009B33
		public unsafe static int iTfwmpAIBVwcJdXQessdnwPTLpF
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_iTfwmpAIBVwcJdXQessdnwPTLpF, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_iTfwmpAIBVwcJdXQessdnwPTLpF, (void*)(&value));
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x0009A330 File Offset: 0x00098530
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x0000B941 File Offset: 0x00009B41
		public unsafe static byte JOdxhCEhCyFSMIzcwehPegmSkHiy
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_JOdxhCEhCyFSMIzcwehPegmSkHiy, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_JOdxhCEhCyFSMIzcwehPegmSkHiy, (void*)(&value));
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x0009A34C File Offset: 0x0009854C
		// (set) Token: 0x06001C6D RID: 7277 RVA: 0x0000B94F File Offset: 0x00009B4F
		public unsafe static byte pngETfayGPvSrOjZjvqgaFZJvfc
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_pngETfayGPvSrOjZjvqgaFZJvfc, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_pngETfayGPvSrOjZjvqgaFZJvfc, (void*)(&value));
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001C6E RID: 7278 RVA: 0x0009A368 File Offset: 0x00098568
		// (set) Token: 0x06001C6F RID: 7279 RVA: 0x0000B95D File Offset: 0x00009B5D
		public unsafe static byte YOsgilLTnUFVpjqmLEEibZdXcYRQ
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_YOsgilLTnUFVpjqmLEEibZdXcYRQ, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_YOsgilLTnUFVpjqmLEEibZdXcYRQ, (void*)(&value));
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x0009A384 File Offset: 0x00098584
		// (set) Token: 0x06001C71 RID: 7281 RVA: 0x0000B96B File Offset: 0x00009B6B
		public unsafe static byte DukFFNvmiLRKsyAjODjrGhQBGnL
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_DukFFNvmiLRKsyAjODjrGhQBGnL, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_DukFFNvmiLRKsyAjODjrGhQBGnL, (void*)(&value));
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x0009A3A0 File Offset: 0x000985A0
		// (set) Token: 0x06001C73 RID: 7283 RVA: 0x0000B979 File Offset: 0x00009B79
		public unsafe static bool fBLvQFYipvjtlfYVBgxEMoFHCiiB
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_fBLvQFYipvjtlfYVBgxEMoFHCiiB, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_fBLvQFYipvjtlfYVBgxEMoFHCiiB, (void*)(&value));
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x0009A3BC File Offset: 0x000985BC
		// (set) Token: 0x06001C75 RID: 7285 RVA: 0x0000B987 File Offset: 0x00009B87
		public unsafe static int SMoAnscTohLhkRCINmKDimcdDrha
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_SMoAnscTohLhkRCINmKDimcdDrha, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_SMoAnscTohLhkRCINmKDimcdDrha, (void*)(&value));
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x0009A3D8 File Offset: 0x000985D8
		// (set) Token: 0x06001C77 RID: 7287 RVA: 0x0000B995 File Offset: 0x00009B95
		public unsafe static int ewAwOWPRZrTGiLDAAiOYHtWvayr
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_ewAwOWPRZrTGiLDAAiOYHtWvayr, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_ewAwOWPRZrTGiLDAAiOYHtWvayr, (void*)(&value));
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x0009A3F4 File Offset: 0x000985F4
		// (set) Token: 0x06001C79 RID: 7289 RVA: 0x0000B9A3 File Offset: 0x00009BA3
		public unsafe static float nbksJZgjBqdspiaJiKOmAmEioaiH
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_nbksJZgjBqdspiaJiKOmAmEioaiH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_nbksJZgjBqdspiaJiKOmAmEioaiH, (void*)(&value));
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x0009A410 File Offset: 0x00098610
		// (set) Token: 0x06001C7B RID: 7291 RVA: 0x0000B9B1 File Offset: 0x00009BB1
		public unsafe static float DugdatQgfbvfYbWbkKLDKCYLPaA
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_DugdatQgfbvfYbWbkKLDKCYLPaA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_DugdatQgfbvfYbWbkKLDKCYLPaA, (void*)(&value));
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001C7C RID: 7292 RVA: 0x0009A42C File Offset: 0x0009862C
		// (set) Token: 0x06001C7D RID: 7293 RVA: 0x0000B9BF File Offset: 0x00009BBF
		public unsafe static float DAUINcLKpAQacqmWMUIzRBtPWQi
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_DAUINcLKpAQacqmWMUIzRBtPWQi, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_DAUINcLKpAQacqmWMUIzRBtPWQi, (void*)(&value));
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x0009A448 File Offset: 0x00098648
		// (set) Token: 0x06001C7F RID: 7295 RVA: 0x0000B9CD File Offset: 0x00009BCD
		public unsafe static bool QYRvzOxFNpkSULNPpVRzHPlduSR
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_QYRvzOxFNpkSULNPpVRzHPlduSR, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_QYRvzOxFNpkSULNPpVRzHPlduSR, (void*)(&value));
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x0009A464 File Offset: 0x00098664
		// (set) Token: 0x06001C81 RID: 7297 RVA: 0x0000B9DB File Offset: 0x00009BDB
		public unsafe static bool ercldrMDMwXEPurVOaoJxnVVpls
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_ercldrMDMwXEPurVOaoJxnVVpls, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_ercldrMDMwXEPurVOaoJxnVVpls, (void*)(&value));
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x0009A480 File Offset: 0x00098680
		// (set) Token: 0x06001C83 RID: 7299 RVA: 0x0000B9E9 File Offset: 0x00009BE9
		public unsafe static bool YPjwmLyiGMgZqaXDYTZImQRTYEO
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_YPjwmLyiGMgZqaXDYTZImQRTYEO, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_YPjwmLyiGMgZqaXDYTZImQRTYEO, (void*)(&value));
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x0009A49C File Offset: 0x0009869C
		// (set) Token: 0x06001C85 RID: 7301 RVA: 0x0000B9F7 File Offset: 0x00009BF7
		public unsafe static bool OPYDCjKKkittUJrThlfyTQNZWEIG
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_OPYDCjKKkittUJrThlfyTQNZWEIG, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_OPYDCjKKkittUJrThlfyTQNZWEIG, (void*)(&value));
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x0009A4B8 File Offset: 0x000986B8
		// (set) Token: 0x06001C87 RID: 7303 RVA: 0x0000BA05 File Offset: 0x00009C05
		public unsafe static float mjBnEAbcHYxisFdFlFoFkBglZOBn
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_mjBnEAbcHYxisFdFlFoFkBglZOBn, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_mjBnEAbcHYxisFdFlFoFkBglZOBn, (void*)(&value));
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x0009A4D4 File Offset: 0x000986D4
		// (set) Token: 0x06001C89 RID: 7305 RVA: 0x0000BA13 File Offset: 0x00009C13
		public unsafe static float VFDHHQcZdJhoVuZYXYHsXvpfeOL
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_VFDHHQcZdJhoVuZYXYHsXvpfeOL, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_VFDHHQcZdJhoVuZYXYHsXvpfeOL, (void*)(&value));
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x0009A4F0 File Offset: 0x000986F0
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x0000BA21 File Offset: 0x00009C21
		public unsafe static float MXGPRGAXeZnmaeVJRhyPEaVTkXQ
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_MXGPRGAXeZnmaeVJRhyPEaVTkXQ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_MXGPRGAXeZnmaeVJRhyPEaVTkXQ, (void*)(&value));
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x0009A50C File Offset: 0x0009870C
		// (set) Token: 0x06001C8D RID: 7309 RVA: 0x0000BA2F File Offset: 0x00009C2F
		public unsafe static float TUDBImFUfxFLWRotJFCpRJvzDZa
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_TUDBImFUfxFLWRotJFCpRJvzDZa, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_TUDBImFUfxFLWRotJFCpRJvzDZa, (void*)(&value));
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001C8E RID: 7310 RVA: 0x0009A528 File Offset: 0x00098728
		// (set) Token: 0x06001C8F RID: 7311 RVA: 0x0000BA3D File Offset: 0x00009C3D
		public unsafe static float bkfuctINqlGyShIdchJBqLCYxstJ
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_bkfuctINqlGyShIdchJBqLCYxstJ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_bkfuctINqlGyShIdchJBqLCYxstJ, (void*)(&value));
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x0009A544 File Offset: 0x00098744
		// (set) Token: 0x06001C91 RID: 7313 RVA: 0x0000BA4B File Offset: 0x00009C4B
		public unsafe static float ckzrduSceznhfUkVNVzAlrFMzOk
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_ckzrduSceznhfUkVNVzAlrFMzOk, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_ckzrduSceznhfUkVNVzAlrFMzOk, (void*)(&value));
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x0009A560 File Offset: 0x00098760
		// (set) Token: 0x06001C93 RID: 7315 RVA: 0x0000BA59 File Offset: 0x00009C59
		public unsafe static float lXKFeRBfejoFIuuyCCeCQPgXmdAP
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_lXKFeRBfejoFIuuyCCeCQPgXmdAP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_lXKFeRBfejoFIuuyCCeCQPgXmdAP, (void*)(&value));
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x0009A57C File Offset: 0x0009877C
		// (set) Token: 0x06001C95 RID: 7317 RVA: 0x0000BA67 File Offset: 0x00009C67
		public unsafe static float qDdCVvKQZbrijiZvgipubafbXOo
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_qDdCVvKQZbrijiZvgipubafbXOo, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_qDdCVvKQZbrijiZvgipubafbXOo, (void*)(&value));
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x0009A598 File Offset: 0x00098798
		// (set) Token: 0x06001C97 RID: 7319 RVA: 0x0000BA75 File Offset: 0x00009C75
		public unsafe static float LcPJePsNJDGRzaAichDdYIgnONuI
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualShock4Driver.NativeFieldInfoPtr_LcPJePsNJDGRzaAichDdYIgnONuI, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualShock4Driver.NativeFieldInfoPtr_LcPJePsNJDGRzaAichDdYIgnONuI, (void*)(&value));
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x0009A5B4 File Offset: 0x000987B4
		// (set) Token: 0x06001C99 RID: 7321 RVA: 0x0000BA83 File Offset: 0x00009C83
		public unsafe bool hbVTfeoNOpiGfjtSvuUJcKveeIPP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_hbVTfeoNOpiGfjtSvuUJcKveeIPP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_hbVTfeoNOpiGfjtSvuUJcKveeIPP)) = value;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x0009A5DC File Offset: 0x000987DC
		// (set) Token: 0x06001C9B RID: 7323 RVA: 0x0000BA9E File Offset: 0x00009C9E
		public unsafe DeviceConnectionType fMiifxYpLKJReuIOPISvCpJbUqYi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_fMiifxYpLKJReuIOPISvCpJbUqYi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_fMiifxYpLKJReuIOPISvCpJbUqYi)) = value;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x0009A604 File Offset: 0x00098804
		// (set) Token: 0x06001C9D RID: 7325 RVA: 0x0000BAB9 File Offset: 0x00009CB9
		public unsafe int egeIAYGpUfUEQnQHRNtccoCwhkb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_egeIAYGpUfUEQnQHRNtccoCwhkb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_egeIAYGpUfUEQnQHRNtccoCwhkb)) = value;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001C9E RID: 7326 RVA: 0x0009A62C File Offset: 0x0009882C
		// (set) Token: 0x06001C9F RID: 7327 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		public unsafe int uBCvvZAaNoajgRatNflOHdudRbrB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_uBCvvZAaNoajgRatNflOHdudRbrB);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_uBCvvZAaNoajgRatNflOHdudRbrB)) = value;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x0009A654 File Offset: 0x00098854
		// (set) Token: 0x06001CA1 RID: 7329 RVA: 0x0000BAEF File Offset: 0x00009CEF
		public unsafe bool mPARfXQHiXPIiWsEdawLAmEocmM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_mPARfXQHiXPIiWsEdawLAmEocmM);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_mPARfXQHiXPIiWsEdawLAmEocmM)) = value;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x0009A67C File Offset: 0x0009887C
		// (set) Token: 0x06001CA3 RID: 7331 RVA: 0x0000BB0A File Offset: 0x00009D0A
		public unsafe byte tmIocfPzYqSkyWAsAqKlPqHeQyA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_tmIocfPzYqSkyWAsAqKlPqHeQyA);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_tmIocfPzYqSkyWAsAqKlPqHeQyA)) = value;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x0009A6A4 File Offset: 0x000988A4
		// (set) Token: 0x06001CA5 RID: 7333 RVA: 0x0000BB25 File Offset: 0x00009D25
		public unsafe int rWuGSHcFIrSEtLmEWnwNAAMIkTQh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_rWuGSHcFIrSEtLmEWnwNAAMIkTQh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_rWuGSHcFIrSEtLmEWnwNAAMIkTQh)) = value;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x0009A6CC File Offset: 0x000988CC
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x0000BB40 File Offset: 0x00009D40
		public unsafe int FXCndKilsLeiQIcUSfpHzZDAPmwF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_FXCndKilsLeiQIcUSfpHzZDAPmwF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_FXCndKilsLeiQIcUSfpHzZDAPmwF)) = value;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x0009A6F4 File Offset: 0x000988F4
		// (set) Token: 0x06001CA9 RID: 7337 RVA: 0x0000BB5B File Offset: 0x00009D5B
		public unsafe int fxDKuXoXhRfNScEQSkchCEEpvBY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_fxDKuXoXhRfNScEQSkchCEEpvBY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_fxDKuXoXhRfNScEQSkchCEEpvBY)) = value;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x0009A71C File Offset: 0x0009891C
		// (set) Token: 0x06001CAB RID: 7339 RVA: 0x0000BB76 File Offset: 0x00009D76
		public unsafe int dBoIMedCMyQNHjRaJpngjHJXfMdE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_dBoIMedCMyQNHjRaJpngjHJXfMdE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_dBoIMedCMyQNHjRaJpngjHJXfMdE)) = value;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x0009A744 File Offset: 0x00098944
		// (set) Token: 0x06001CAD RID: 7341 RVA: 0x0000BB91 File Offset: 0x00009D91
		public unsafe int izYKmDpxFzOrqRbOivvudHllUsE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_izYKmDpxFzOrqRbOivvudHllUsE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_izYKmDpxFzOrqRbOivvudHllUsE)) = value;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x0009A76C File Offset: 0x0009896C
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x0000BBAC File Offset: 0x00009DAC
		public unsafe int GeDQfGevPhhOtATwmXkLyHvWccw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_GeDQfGevPhhOtATwmXkLyHvWccw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_GeDQfGevPhhOtATwmXkLyHvWccw)) = value;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x0009A794 File Offset: 0x00098994
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x0000BBC7 File Offset: 0x00009DC7
		public unsafe NativeBuffer VqjireeisHBGAbOmixQcKOQABZY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_VqjireeisHBGAbOmixQcKOQABZY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_VqjireeisHBGAbOmixQcKOQABZY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x0009A7C4 File Offset: 0x000989C4
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x0000BBE6 File Offset: 0x00009DE6
		public unsafe NativeBuffer SEQenGfoIoNZmaGLiQDgmYcHfBRG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_SEQenGfoIoNZmaGLiQDgmYcHfBRG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_SEQenGfoIoNZmaGLiQDgmYcHfBRG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x0009A7F4 File Offset: 0x000989F4
		// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x0000BC05 File Offset: 0x00009E05
		public unsafe OutputReport NXVqXgfUsQHbVRrEpuYEreBlzpN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_NXVqXgfUsQHbVRrEpuYEreBlzpN);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_NXVqXgfUsQHbVRrEpuYEreBlzpN)) = value;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x0009A81C File Offset: 0x00098A1C
		// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x0000BC20 File Offset: 0x00009E20
		public unsafe Func<OutputReport, bool> dzydtpDkcOlbZPaRhVbfGNBdrDQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_dzydtpDkcOlbZPaRhVbfGNBdrDQ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<OutputReport, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_dzydtpDkcOlbZPaRhVbfGNBdrDQ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x0009A84C File Offset: 0x00098A4C
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x0000BC3F File Offset: 0x00009E3F
		public unsafe Action<OutputReport> MqcIIdsSwUqQdRoXaTgVghcDhrW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_MqcIIdsSwUqQdRoXaTgVghcDhrW);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<OutputReport>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_MqcIIdsSwUqQdRoXaTgVghcDhrW), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x0009A87C File Offset: 0x00098A7C
		// (set) Token: 0x06001CBB RID: 7355 RVA: 0x0000BC5E File Offset: 0x00009E5E
		public unsafe HIDDeviceDriver.GetHidFeatureData vXhBOHFjjsQqepcCZLmNAKpcINBV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_vXhBOHFjjsQqepcCZLmNAKpcINBV);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HIDDeviceDriver.GetHidFeatureData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_vXhBOHFjjsQqepcCZLmNAKpcINBV), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x0009A8AC File Offset: 0x00098AAC
		// (set) Token: 0x06001CBD RID: 7357 RVA: 0x0000BC7D File Offset: 0x00009E7D
		public unsafe bool WiKTTbpsgABuAkMhYSavFVjifRv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_WiKTTbpsgABuAkMhYSavFVjifRv);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_WiKTTbpsgABuAkMhYSavFVjifRv)) = value;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x0009A8D4 File Offset: 0x00098AD4
		// (set) Token: 0x06001CBF RID: 7359 RVA: 0x0000BC98 File Offset: 0x00009E98
		public unsafe bool GjYzRFszhGQQgQSGrnIRVGWAJXr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_GjYzRFszhGQQgQSGrnIRVGWAJXr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_GjYzRFszhGQQgQSGrnIRVGWAJXr)) = value;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x0009A8FC File Offset: 0x00098AFC
		// (set) Token: 0x06001CC1 RID: 7361 RVA: 0x0000BCB3 File Offset: 0x00009EB3
		public unsafe double vWODbbChHxjsJwFcccLzWSgbQGAI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_vWODbbChHxjsJwFcccLzWSgbQGAI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_vWODbbChHxjsJwFcccLzWSgbQGAI)) = value;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x0009A924 File Offset: 0x00098B24
		// (set) Token: 0x06001CC3 RID: 7363 RVA: 0x0000BCCE File Offset: 0x00009ECE
		public unsafe byte XVfeDFKQSiWWjEnCYqeBmfVLANBm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_XVfeDFKQSiWWjEnCYqeBmfVLANBm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_XVfeDFKQSiWWjEnCYqeBmfVLANBm)) = value;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x0009A94C File Offset: 0x00098B4C
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x0000BCE9 File Offset: 0x00009EE9
		public unsafe Quaternion kEQdqkMxSYRqzzGPHAxtXPlPzkZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_kEQdqkMxSYRqzzGPHAxtXPlPzkZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_kEQdqkMxSYRqzzGPHAxtXPlPzkZ)) = value;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x0009A974 File Offset: 0x00098B74
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x0000BD04 File Offset: 0x00009F04
		public unsafe ushort RTKlxLjGuZLRqfVuXrlNDhwBiTy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_RTKlxLjGuZLRqfVuXrlNDhwBiTy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_RTKlxLjGuZLRqfVuXrlNDhwBiTy)) = value;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x0009A99C File Offset: 0x00098B9C
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x0000BD1F File Offset: 0x00009F1F
		public unsafe float ippVKLLMqIBFhRtXoenvVQntAJd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_ippVKLLMqIBFhRtXoenvVQntAJd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_ippVKLLMqIBFhRtXoenvVQntAJd)) = value;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x0009A9C4 File Offset: 0x00098BC4
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x0000BD3A File Offset: 0x00009F3A
		public unsafe double qjntYfLoESbAWHDBNDGxRCXJMfy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_qjntYfLoESbAWHDBNDGxRCXJMfy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_qjntYfLoESbAWHDBNDGxRCXJMfy)) = value;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x0009A9EC File Offset: 0x00098BEC
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x0000BD55 File Offset: 0x00009F55
		public unsafe float XnRnoVdLhJkUOHOAQhipOOfFLpk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_XnRnoVdLhJkUOHOAQhipOOfFLpk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_XnRnoVdLhJkUOHOAQhipOOfFLpk)) = value;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x0009AA14 File Offset: 0x00098C14
		// (set) Token: 0x06001CCF RID: 7375 RVA: 0x0000BD70 File Offset: 0x00009F70
		public unsafe byte bUbhTMCGWaCoOqSuDMxcebgtRqzV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_bUbhTMCGWaCoOqSuDMxcebgtRqzV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_bUbhTMCGWaCoOqSuDMxcebgtRqzV)) = value;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x0009AA3C File Offset: 0x00098C3C
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x0000BD8B File Offset: 0x00009F8B
		public unsafe byte OLKxRVqOsIErBUQFLStrlOJjitj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_OLKxRVqOsIErBUQFLStrlOJjitj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_OLKxRVqOsIErBUQFLStrlOJjitj)) = value;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x0009AA64 File Offset: 0x00098C64
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x0000BDA6 File Offset: 0x00009FA6
		public unsafe Quaternion oHPGAxVesPYWMwkICufJHTEytZG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_oHPGAxVesPYWMwkICufJHTEytZG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_oHPGAxVesPYWMwkICufJHTEytZG)) = value;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x0009AA8C File Offset: 0x00098C8C
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x0000BDC1 File Offset: 0x00009FC1
		public unsafe Quaternion nQtUtyADXujDLjRfcvigVPkcmUX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_nQtUtyADXujDLjRfcvigVPkcmUX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_nQtUtyADXujDLjRfcvigVPkcmUX)) = value;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x0009AAB4 File Offset: 0x00098CB4
		// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x0000BDDC File Offset: 0x00009FDC
		public unsafe bool pmmntafFsJVEOxFZPqxaaiZpAMO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_pmmntafFsJVEOxFZPqxaaiZpAMO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_pmmntafFsJVEOxFZPqxaaiZpAMO)) = value;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x0009AADC File Offset: 0x00098CDC
		// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x0000BDF7 File Offset: 0x00009FF7
		public unsafe int aOwynHDBqdQEJSMuGFrjRNscfyAD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_aOwynHDBqdQEJSMuGFrjRNscfyAD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_aOwynHDBqdQEJSMuGFrjRNscfyAD)) = value;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x0009AB04 File Offset: 0x00098D04
		// (set) Token: 0x06001CDB RID: 7387 RVA: 0x0000BE12 File Offset: 0x0000A012
		public unsafe Il2CppStructArray<int> oTQFLvxokTfPetxLSxzfnaixHvs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_oTQFLvxokTfPetxLSxzfnaixHvs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_oTQFLvxokTfPetxLSxzfnaixHvs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x0009AB34 File Offset: 0x00098D34
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x0000BE31 File Offset: 0x0000A031
		public unsafe Il2CppStructArray<int> DhbhSRVhmFGIEaEXjUaEnRbxQZd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_DhbhSRVhmFGIEaEXjUaEnRbxQZd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualShock4Driver.NativeFieldInfoPtr_DhbhSRVhmFGIEaEXjUaEnRbxQZd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001793 RID: 6035
		private static readonly IntPtr NativeFieldInfoPtr_cBswOuBTFJaQmJaEsTSUwghjEsxb;

		// Token: 0x04001794 RID: 6036
		private static readonly IntPtr NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm;

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeFieldInfoPtr_ZSAekMXsJdpwJeuHzaalTvrqTXZ;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeFieldInfoPtr_xQFBlnjHmSMxSYBxUcplNCrUIpHy;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeFieldInfoPtr_DXQOduZMAdakgKHULREouGGIMsj;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeFieldInfoPtr_jkpagfZjLjeageiKHUvdcGIBUyjQ;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeFieldInfoPtr_CbvTpyUAreHQTqRwrRyHFkkvRu;

		// Token: 0x0400179A RID: 6042
		private static readonly IntPtr NativeFieldInfoPtr_qkfbSOvdxzFTGQsCjAxNayadEWhk;

		// Token: 0x0400179B RID: 6043
		private static readonly IntPtr NativeFieldInfoPtr_sstgLgFYucqXUgQCuJWZzpHiirhL;

		// Token: 0x0400179C RID: 6044
		private static readonly IntPtr NativeFieldInfoPtr_AHJqxkYPMecTbQnOZRgFvJYDGTg;

		// Token: 0x0400179D RID: 6045
		private static readonly IntPtr NativeFieldInfoPtr_ykFUEgafLAgAceDkWcqiMSzQgGhj;

		// Token: 0x0400179E RID: 6046
		private static readonly IntPtr NativeFieldInfoPtr_ucCwnEJshdgPokipDfKZUPXVGns;

		// Token: 0x0400179F RID: 6047
		private static readonly IntPtr NativeFieldInfoPtr_HQywWIGQbJvUyoAzHWTXqleTChs;

		// Token: 0x040017A0 RID: 6048
		private static readonly IntPtr NativeFieldInfoPtr_cHNhpgkLYTObmpHxVWxLGMeDyrl;

		// Token: 0x040017A1 RID: 6049
		private static readonly IntPtr NativeFieldInfoPtr_iZucelPQVvvGHDiPkrqCheppWEb;

		// Token: 0x040017A2 RID: 6050
		private static readonly IntPtr NativeFieldInfoPtr_uxwENVeAtCyNlYtYwbcddIUTAOou;

		// Token: 0x040017A3 RID: 6051
		private static readonly IntPtr NativeFieldInfoPtr_LgKeAUHCkufZaobBGjJCDaKYadH;

		// Token: 0x040017A4 RID: 6052
		private static readonly IntPtr NativeFieldInfoPtr_rTYGvTGnYfwSgAKaOlRpiyzYrWS;

		// Token: 0x040017A5 RID: 6053
		private static readonly IntPtr NativeFieldInfoPtr_FXtDWUVkUWyrNZDVfPmoAYzjdSk;

		// Token: 0x040017A6 RID: 6054
		private static readonly IntPtr NativeFieldInfoPtr_wHEacDZJRphkGPCiPiOJlnwszcO;

		// Token: 0x040017A7 RID: 6055
		private static readonly IntPtr NativeFieldInfoPtr_KbJfnNWgRWWhYQPqfyOdakWTCzV;

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeFieldInfoPtr_GxwuqUBQlXZIYUGIfFZXGWQpDaP;

		// Token: 0x040017A9 RID: 6057
		private static readonly IntPtr NativeFieldInfoPtr_hcBaVJxFQfmUjEoteGSzULttyVK;

		// Token: 0x040017AA RID: 6058
		private static readonly IntPtr NativeFieldInfoPtr_CCVbhVJfxwwdDigIhqkdBPtgRraU;

		// Token: 0x040017AB RID: 6059
		private static readonly IntPtr NativeFieldInfoPtr_BBxhpfDMNTIyFeBupCZIVerwBWD;

		// Token: 0x040017AC RID: 6060
		private static readonly IntPtr NativeFieldInfoPtr_DjKakIgesLnAHNafOLmjWaZijsjK;

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeFieldInfoPtr_foWgjLXVSVMFiWVEEVhFNgtUENi;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeFieldInfoPtr_yNXkfmYzMlAdJuzyPdItIntpuRG;

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeFieldInfoPtr_izvXmSrSPbVoCbIocjuxlbdJFKp;

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeFieldInfoPtr_geesShSZbWMRDQXWdWhQsuPIYbg;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeFieldInfoPtr_EsFJPdDRcznZMMLQtKTzZswcLZN;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeFieldInfoPtr_DfBydhNWOOkPYugrHJaqMYmzYxW;

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeFieldInfoPtr_axsAWDoBfYTvKuiIBVCENVMNClI;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeFieldInfoPtr_RkmXSIwacUHALbRdEDzDbXwbiNm;

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeFieldInfoPtr_zNJxXdOIpKiDcgASoCbBJWVmwUT;

		// Token: 0x040017B6 RID: 6070
		private static readonly IntPtr NativeFieldInfoPtr_RUqxFhXZXCJwBaIXjyWYPbcseaN;

		// Token: 0x040017B7 RID: 6071
		private static readonly IntPtr NativeFieldInfoPtr_RlPbGpoetcVHHVwCmAAihzjLuYH;

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeFieldInfoPtr_iTfwmpAIBVwcJdXQessdnwPTLpF;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeFieldInfoPtr_JOdxhCEhCyFSMIzcwehPegmSkHiy;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeFieldInfoPtr_pngETfayGPvSrOjZjvqgaFZJvfc;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeFieldInfoPtr_YOsgilLTnUFVpjqmLEEibZdXcYRQ;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeFieldInfoPtr_DukFFNvmiLRKsyAjODjrGhQBGnL;

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeFieldInfoPtr_fBLvQFYipvjtlfYVBgxEMoFHCiiB;

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeFieldInfoPtr_SMoAnscTohLhkRCINmKDimcdDrha;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeFieldInfoPtr_ewAwOWPRZrTGiLDAAiOYHtWvayr;

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeFieldInfoPtr_nbksJZgjBqdspiaJiKOmAmEioaiH;

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeFieldInfoPtr_DugdatQgfbvfYbWbkKLDKCYLPaA;

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeFieldInfoPtr_DAUINcLKpAQacqmWMUIzRBtPWQi;

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeFieldInfoPtr_QYRvzOxFNpkSULNPpVRzHPlduSR;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeFieldInfoPtr_ercldrMDMwXEPurVOaoJxnVVpls;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeFieldInfoPtr_YPjwmLyiGMgZqaXDYTZImQRTYEO;

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeFieldInfoPtr_OPYDCjKKkittUJrThlfyTQNZWEIG;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeFieldInfoPtr_mjBnEAbcHYxisFdFlFoFkBglZOBn;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeFieldInfoPtr_VFDHHQcZdJhoVuZYXYHsXvpfeOL;

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeFieldInfoPtr_MXGPRGAXeZnmaeVJRhyPEaVTkXQ;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeFieldInfoPtr_TUDBImFUfxFLWRotJFCpRJvzDZa;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeFieldInfoPtr_bkfuctINqlGyShIdchJBqLCYxstJ;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeFieldInfoPtr_ckzrduSceznhfUkVNVzAlrFMzOk;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeFieldInfoPtr_lXKFeRBfejoFIuuyCCeCQPgXmdAP;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeFieldInfoPtr_qDdCVvKQZbrijiZvgipubafbXOo;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeFieldInfoPtr_LcPJePsNJDGRzaAichDdYIgnONuI;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeFieldInfoPtr_hbVTfeoNOpiGfjtSvuUJcKveeIPP;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeFieldInfoPtr_fMiifxYpLKJReuIOPISvCpJbUqYi;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeFieldInfoPtr_egeIAYGpUfUEQnQHRNtccoCwhkb;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeFieldInfoPtr_uBCvvZAaNoajgRatNflOHdudRbrB;

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeFieldInfoPtr_mPARfXQHiXPIiWsEdawLAmEocmM;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeFieldInfoPtr_tmIocfPzYqSkyWAsAqKlPqHeQyA;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeFieldInfoPtr_rWuGSHcFIrSEtLmEWnwNAAMIkTQh;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeFieldInfoPtr_FXCndKilsLeiQIcUSfpHzZDAPmwF;

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeFieldInfoPtr_fxDKuXoXhRfNScEQSkchCEEpvBY;

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeFieldInfoPtr_dBoIMedCMyQNHjRaJpngjHJXfMdE;

		// Token: 0x040017DA RID: 6106
		private static readonly IntPtr NativeFieldInfoPtr_izYKmDpxFzOrqRbOivvudHllUsE;

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeFieldInfoPtr_GeDQfGevPhhOtATwmXkLyHvWccw;

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeFieldInfoPtr_VqjireeisHBGAbOmixQcKOQABZY;

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeFieldInfoPtr_SEQenGfoIoNZmaGLiQDgmYcHfBRG;

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeFieldInfoPtr_NXVqXgfUsQHbVRrEpuYEreBlzpN;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeFieldInfoPtr_dzydtpDkcOlbZPaRhVbfGNBdrDQ;

		// Token: 0x040017E0 RID: 6112
		private static readonly IntPtr NativeFieldInfoPtr_MqcIIdsSwUqQdRoXaTgVghcDhrW;

		// Token: 0x040017E1 RID: 6113
		private static readonly IntPtr NativeFieldInfoPtr_vXhBOHFjjsQqepcCZLmNAKpcINBV;

		// Token: 0x040017E2 RID: 6114
		private static readonly IntPtr NativeFieldInfoPtr_WiKTTbpsgABuAkMhYSavFVjifRv;

		// Token: 0x040017E3 RID: 6115
		private static readonly IntPtr NativeFieldInfoPtr_GjYzRFszhGQQgQSGrnIRVGWAJXr;

		// Token: 0x040017E4 RID: 6116
		private static readonly IntPtr NativeFieldInfoPtr_vWODbbChHxjsJwFcccLzWSgbQGAI;

		// Token: 0x040017E5 RID: 6117
		private static readonly IntPtr NativeFieldInfoPtr_XVfeDFKQSiWWjEnCYqeBmfVLANBm;

		// Token: 0x040017E6 RID: 6118
		private static readonly IntPtr NativeFieldInfoPtr_kEQdqkMxSYRqzzGPHAxtXPlPzkZ;

		// Token: 0x040017E7 RID: 6119
		private static readonly IntPtr NativeFieldInfoPtr_RTKlxLjGuZLRqfVuXrlNDhwBiTy;

		// Token: 0x040017E8 RID: 6120
		private static readonly IntPtr NativeFieldInfoPtr_ippVKLLMqIBFhRtXoenvVQntAJd;

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeFieldInfoPtr_qjntYfLoESbAWHDBNDGxRCXJMfy;

		// Token: 0x040017EA RID: 6122
		private static readonly IntPtr NativeFieldInfoPtr_XnRnoVdLhJkUOHOAQhipOOfFLpk;

		// Token: 0x040017EB RID: 6123
		private static readonly IntPtr NativeFieldInfoPtr_bUbhTMCGWaCoOqSuDMxcebgtRqzV;

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeFieldInfoPtr_OLKxRVqOsIErBUQFLStrlOJjitj;

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeFieldInfoPtr_oHPGAxVesPYWMwkICufJHTEytZG;

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeFieldInfoPtr_nQtUtyADXujDLjRfcvigVPkcmUX;

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeFieldInfoPtr_pmmntafFsJVEOxFZPqxaaiZpAMO;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeFieldInfoPtr_aOwynHDBqdQEJSMuGFrjRNscfyAD;

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeFieldInfoPtr_oTQFLvxokTfPetxLSxzfnaixHvs;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeFieldInfoPtr_DhbhSRVhmFGIEaEXjUaEnRbxQZd;

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeMethodInfoPtr_get_isVibrating_Private_get_Boolean_0;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeMethodInfoPtr_get_BatteryLevel_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftMotor_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftMotor_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x040017F7 RID: 6135
		private static readonly IntPtr NativeMethodInfoPtr_get_RightMotor_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeMethodInfoPtr_set_RightMotor_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeMethodInfoPtr_get_LightColorR_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeMethodInfoPtr_set_LightColorR_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeMethodInfoPtr_get_LightColorG_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeMethodInfoPtr_set_LightColorG_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x040017FD RID: 6141
		private static readonly IntPtr NativeMethodInfoPtr_get_LightColorB_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040017FE RID: 6142
		private static readonly IntPtr NativeMethodInfoPtr_set_LightColorB_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeMethodInfoPtr_get_LightFlashOnDuration_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeMethodInfoPtr_set_LightFlashOnDuration_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeMethodInfoPtr_get_LightFlashOffDuration_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001802 RID: 6146
		private static readonly IntPtr NativeMethodInfoPtr_set_LightFlashOffDuration_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeMethodInfoPtr_get_AccelerometerValue_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeMethodInfoPtr_get_AccelerometerValueRaw_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeMethodInfoPtr_get_GyroscopeValue_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeMethodInfoPtr_get_GyroscopeValueRaw_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeMethodInfoPtr_get_LastGyroscopeValue_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04001808 RID: 6152
		private static readonly IntPtr NativeMethodInfoPtr_get_LastGyroscopeValueRaw_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04001809 RID: 6153
		private static readonly IntPtr NativeMethodInfoPtr_get_Orientation_Public_Virtual_Final_New_get_Quaternion_0;

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxTouches_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchCount_Public_Virtual_Final_New_Int32_0;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeMethodInfoPtr_IsTouchingAtIndex_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeMethodInfoPtr_IsTouchingAtTouchId_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x0400180F RID: 6159
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchIdAtIndex_Public_Virtual_Final_New_Int32_Int32_0;

		// Token: 0x04001810 RID: 6160
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsoluteByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04001814 RID: 6164
		private static readonly IntPtr NativeMethodInfoPtr_StopLightFlash_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001815 RID: 6165
		private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001816 RID: 6166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InitArgs_0;

		// Token: 0x04001817 RID: 6167
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0;

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeMethodInfoPtr_ParseInputReport_Public_Virtual_Boolean_IntPtr_Int32_Double_0;

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeMethodInfoPtr_CreateControllerExtension_Public_Virtual_Extension_0;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeMethodInfoPtr_TSrVJoovajrfJhhpgPSTUJfwLdn_Private_Void_rBapAxSjeCWOiOHyzennMIRNCHfj_0;

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeMethodInfoPtr_zNXomrMcpdzggtTitEdjWdzqgEbj_Private_Boolean_rBapAxSjeCWOiOHyzennMIRNCHfj_0;

		// Token: 0x0400181C RID: 6172
		private static readonly IntPtr NativeMethodInfoPtr_IuZFpZfntxLYutBfTAuqVYKxfjj_Private_Void_0;

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeMethodInfoPtr_bWlObuwhPuWKIEdjMaLCkLFuAubl_Private_Boolean_rBapAxSjeCWOiOHyzennMIRNCHfj_0;

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeMethodInfoPtr_QLZdJmwnUkddZisUnLmixtMACSh_Private_Void_NativeBuffer_Double_0;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeMethodInfoPtr_gbHdOZilzwmhPaLsoSTdCfNBZKKu_Private_Void_Il2CppReferenceArray_1_HIDControllerElement_NativeBuffer_Double_0;

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeMethodInfoPtr_KHqFCPtEwwtfLgFTiAQgQrcOjjb_Private_Void_0;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeMethodInfoPtr_LeplGUzBFQKWBFpGxiDontkepOK_Private_Void_NativeBuffer_0;

		// Token: 0x04001822 RID: 6178
		private static readonly IntPtr NativeMethodInfoPtr_TLwGAPVnufqvIFbiUtPrqoyNGkr_Private_Void_0;

		// Token: 0x04001823 RID: 6179
		private static readonly IntPtr NativeMethodInfoPtr_cohbXzjxzOcNAeSeyhxjbfXCJFQ_Private_Static_Boolean_byref_Vector3_0;

		// Token: 0x04001824 RID: 6180
		private static readonly IntPtr NativeMethodInfoPtr_OeYAIeGFRPZFIOSRbUgsokmVUlq_Private_Void_Vector3_Vector3_0;

		// Token: 0x04001825 RID: 6181
		private static readonly IntPtr NativeMethodInfoPtr_vZfQKBwCEWApahARXbtasPYbHzZ_Private_Static_Quaternion_Quaternion_Vector3_0;

		// Token: 0x04001826 RID: 6182
		private static readonly IntPtr NativeMethodInfoPtr_HNzAAnmQWRfPwDoAHmOVRTmQhjHg_Private_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04001827 RID: 6183
		private static readonly IntPtr NativeMethodInfoPtr_thTaDDdinQFebglkGeuCSsdQcuKj_Private_Quaternion_Quaternion_jzVxvhtsjKltyydiJeoxkueAqME_0;

		// Token: 0x04001828 RID: 6184
		private static readonly IntPtr NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0;

		// Token: 0x04001829 RID: 6185
		private static readonly IntPtr NativeMethodInfoPtr_TLAawbbzgTTOntVMVRSOYGgBlSz_Private_Single_Single_Single_0;

		// Token: 0x0400182A RID: 6186
		private static readonly IntPtr NativeMethodInfoPtr_TgJSJBfkacluENeCrcEMrjyCzZk_Private_Vector3_Vector3_Single_0;

		// Token: 0x0400182B RID: 6187
		private static readonly IntPtr NativeMethodInfoPtr_EVPzweUACCpCpHpeeEMnGnyiGub_Private_Quaternion_Vector3_Single_0;

		// Token: 0x0400182C RID: 6188
		private static readonly IntPtr NativeMethodInfoPtr_FTcGFQGKepOCGivEwiXcIfpiwzo_Private_Quaternion_Vector3_Single_0;

		// Token: 0x0400182D RID: 6189
		private static readonly IntPtr NativeMethodInfoPtr_fQsbUcErhAOleloWxhSUBrwCiPqT_Private_Single_Vector3_0;

		// Token: 0x0400182E RID: 6190
		private static readonly IntPtr NativeMethodInfoPtr_ekTnVhTROxwNIqHvokaYcuOYwut_Private_Boolean_Single_0;

		// Token: 0x0400182F RID: 6191
		private static readonly IntPtr NativeMethodInfoPtr_robusEWPfTfHCeHSBdccMSzDezZ_Private_Boolean_Vector3_byref_vusGPPHdFNxUjCOgdVnBzVBgWSV_0;

		// Token: 0x04001830 RID: 6192
		private static readonly IntPtr NativeMethodInfoPtr_DIkDxlDsItuOVMlNgZuHlQvMhaFQ_Private_Boolean_Vector3_0;

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeMethodInfoPtr_uaWAYcACiSsMWDcNpMnjBRRdSgR_Private_Boolean_Vector3_0;

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeMethodInfoPtr_DtptwGvMHHWYtiObmjGUBSGKWWS_Private_Vector3_Il2CppStructArray_1_Single_0;

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeMethodInfoPtr_ThbIRbwHDVgOvNnDNaPNIFyStTC_Private_Vector3_ExpandableArray_DataContainer_1_vwnDNljqUPuTIauvXLOcbBHPCtP_0;

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeMethodInfoPtr_ThbIRbwHDVgOvNnDNaPNIFyStTC_Private_Vector3_Vector3_Single_0;

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeMethodInfoPtr_SAHHnzXBzBbRKuuXiURZugBrZSC_Private_Vector3_Vector3_0;

		// Token: 0x04001836 RID: 6198
		private static readonly IntPtr NativeMethodInfoPtr_jouvWBjeMlbfGjdhJNLFnQsLdBOb_Private_Int32_Int32_0;

		// Token: 0x04001837 RID: 6199
		private static readonly IntPtr NativeMethodInfoPtr_prYGimAxzhhkgHXVHtncfHnGFYY_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_0;

		// Token: 0x04001838 RID: 6200
		private static readonly IntPtr NativeMethodInfoPtr_qeFMJjnMLTATARRnrcCxoPuiWfW_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_0;

		// Token: 0x04001839 RID: 6201
		private static readonly IntPtr NativeMethodInfoPtr_nQkXLniZUrHBOFIEofKzaOcIykH_Private_Single_0;

		// Token: 0x0400183A RID: 6202
		private static readonly IntPtr NativeMethodInfoPtr_sDEBJHxzkRveoJulMncayCApMQt_Private_Void_NativeBuffer_Il2CppStructArray_1_TouchData_0;

		// Token: 0x0400183B RID: 6203
		private static readonly IntPtr NativeMethodInfoPtr_okliethpUEesGZsNxgsPNrXkCiZ_Private_Int32_Int32_Boolean_Int32_0;

		// Token: 0x0400183C RID: 6204
		private static readonly IntPtr NativeMethodInfoPtr_dGrqytUXXWkxJliqQJXVhZPBxBd_Private_Void_0;

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400183E RID: 6206
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Static_Boolean_Int32_Int32_0;

		// Token: 0x0200032F RID: 815
		[OriginalName("Rewired_Core.dll", "", "jzVxvhtsjKltyydiJeoxkueAqME")]
		public enum jzVxvhtsjKltyydiJeoxkueAqME
		{
			// Token: 0x040038BF RID: 14527
			QFCZGlfZVeiVmaDBRgNsKFqbawas,
			// Token: 0x040038C0 RID: 14528
			eDYTIcIkzAWXVvGzVfexWBhpAnL,
			// Token: 0x040038C1 RID: 14529
			sPWfPaEuGSIDnmqEualXByKukuvB
		}

		// Token: 0x02000330 RID: 816
		[OriginalName("Rewired_Core.dll", "", "vusGPPHdFNxUjCOgdVnBzVBgWSV")]
		public enum vusGPPHdFNxUjCOgdVnBzVBgWSV
		{
			// Token: 0x040038C3 RID: 14531
			urhBwQidoSAKHIhcxeCWNbALMhkh,
			// Token: 0x040038C4 RID: 14532
			WwnbAovhLwkRABETTocRgkxcAOjg,
			// Token: 0x040038C5 RID: 14533
			eDYTIcIkzAWXVvGzVfexWBhpAnL
		}
	}
}

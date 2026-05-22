using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppI2.Loc
{
	// Token: 0x0200023C RID: 572
	public class ILanguageSource : Il2CppObjectBase
	{
		// Token: 0x0600438F RID: 17295 RVA: 0x000FAC7C File Offset: 0x000F8E7C
		// Note: this type is marked as 'beforefieldinit'.
		static ILanguageSource()
		{
			Il2CppClassPointerStore<ILanguageSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "ILanguageSource");
			ILanguageSource.NativeMethodInfoPtr_get_SourceData_Public_Abstract_Virtual_New_get_LanguageSourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILanguageSource>.NativeClassPtr, 100669940);
			ILanguageSource.NativeMethodInfoPtr_set_SourceData_Public_Abstract_Virtual_New_set_Void_LanguageSourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILanguageSource>.NativeClassPtr, 100669941);
		}

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x06004390 RID: 17296 RVA: 0x000FACCC File Offset: 0x000F8ECC
		// (set) Token: 0x06004391 RID: 17297 RVA: 0x000FAD18 File Offset: 0x000F8F18
		public unsafe virtual LanguageSourceData SourceData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILanguageSource.NativeMethodInfoPtr_get_SourceData_Public_Abstract_Virtual_New_get_LanguageSourceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageSourceData>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILanguageSource.NativeMethodInfoPtr_set_SourceData_Public_Abstract_Virtual_New_set_Void_LanguageSourceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x00029043 File Offset: 0x00027243
		public ILanguageSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002994 RID: 10644
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceData_Public_Abstract_Virtual_New_get_LanguageSourceData_0;

		// Token: 0x04002995 RID: 10645
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceData_Public_Abstract_Virtual_New_set_Void_LanguageSourceData_0;
	}
}

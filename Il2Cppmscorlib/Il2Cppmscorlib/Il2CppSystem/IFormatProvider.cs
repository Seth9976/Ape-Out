using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000BF RID: 191
	public class IFormatProvider : Il2CppObjectBase
	{
		// Token: 0x06000D47 RID: 3399 RVA: 0x0000579F File Offset: 0x0000399F
		// Note: this type is marked as 'beforefieldinit'.
		static IFormatProvider()
		{
			Il2CppClassPointerStore<IFormatProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IFormatProvider");
			IFormatProvider.NativeMethodInfoPtr_GetFormat_Public_Abstract_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormatProvider>.NativeClassPtr, 100665536);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x0005FF6C File Offset: 0x0005E16C
		[CallerCount(0)]
		public unsafe virtual Object GetFormat(Type formatType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormatProvider.NativeMethodInfoPtr_GetFormat_Public_Abstract_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x000057CE File Offset: 0x000039CE
		public IFormatProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Abstract_Virtual_New_Object_Type_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200042C RID: 1068
	[Serializable]
	public class CustomConstantAttribute : Attribute
	{
		// Token: 0x06004339 RID: 17209 RVA: 0x001379A8 File Offset: 0x00135BA8
		// Note: this type is marked as 'beforefieldinit'.
		static CustomConstantAttribute()
		{
			Il2CppClassPointerStore<CustomConstantAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "CustomConstantAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomConstantAttribute>.NativeClassPtr);
			CustomConstantAttribute.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConstantAttribute>.NativeClassPtr, 100673129);
			CustomConstantAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomConstantAttribute>.NativeClassPtr, 100673130);
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x0600433A RID: 17210 RVA: 0x00137A00 File Offset: 0x00135C00
		public unsafe virtual Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomConstantAttribute.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x00137A4C File Offset: 0x00135C4C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomConstantAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomConstantAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomConstantAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x0001976B File Offset: 0x0001796B
		public CustomConstantAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040036AD RID: 13997
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040036AE RID: 13998
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

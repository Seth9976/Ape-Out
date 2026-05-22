using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000E3 RID: 227
	[Serializable]
	public class ReflectionOnlyType : RuntimeType
	{
		// Token: 0x06000F87 RID: 3975 RVA: 0x0006AFB0 File Offset: 0x000691B0
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionOnlyType()
		{
			Il2CppClassPointerStore<ReflectionOnlyType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ReflectionOnlyType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionOnlyType>.NativeClassPtr);
			ReflectionOnlyType.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionOnlyType>.NativeClassPtr, 100665952);
			ReflectionOnlyType.NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_get_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionOnlyType>.NativeClassPtr, 100665953);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0006B008 File Offset: 0x00069208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162626, XrefRangeEnd = 162630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionOnlyType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionOnlyType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionOnlyType.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x0006B044 File Offset: 0x00069244
		public unsafe override RuntimeTypeHandle TypeHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162630, XrefRangeEnd = 162637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReflectionOnlyType.NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_get_RuntimeTypeHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00005E36 File Offset: 0x00004036
		public ReflectionOnlyType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_get_RuntimeTypeHandle_0;
	}
}

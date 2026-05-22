using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x0200003F RID: 63
	public class SupportsChildTracksAttribute : Attribute
	{
		// Token: 0x0600049E RID: 1182 RVA: 0x00016B30 File Offset: 0x00014D30
		// Note: this type is marked as 'beforefieldinit'.
		static SupportsChildTracksAttribute()
		{
			Il2CppClassPointerStore<SupportsChildTracksAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "SupportsChildTracksAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupportsChildTracksAttribute>.NativeClassPtr);
			SupportsChildTracksAttribute.NativeFieldInfoPtr_childType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportsChildTracksAttribute>.NativeClassPtr, "childType");
			SupportsChildTracksAttribute.NativeFieldInfoPtr_levels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportsChildTracksAttribute>.NativeClassPtr, "levels");
			SupportsChildTracksAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportsChildTracksAttribute>.NativeClassPtr, 100664068);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00016B9C File Offset: 0x00014D9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 22674, RefRangeEnd = 22677, XrefRangeStart = 22674, XrefRangeEnd = 22677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupportsChildTracksAttribute(Type childType = null, int levels = 2147483647)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupportsChildTracksAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(childType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref levels;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportsChildTracksAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000037C4 File Offset: 0x000019C4
		public SupportsChildTracksAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00016BF8 File Offset: 0x00014DF8
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x000037CD File Offset: 0x000019CD
		public unsafe Type childType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportsChildTracksAttribute.NativeFieldInfoPtr_childType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportsChildTracksAttribute.NativeFieldInfoPtr_childType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00016C28 File Offset: 0x00014E28
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x000037EC File Offset: 0x000019EC
		public unsafe int levels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportsChildTracksAttribute.NativeFieldInfoPtr_levels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportsChildTracksAttribute.NativeFieldInfoPtr_levels)) = value;
			}
		}

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeFieldInfoPtr_childType;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeFieldInfoPtr_levels;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_0;
	}
}

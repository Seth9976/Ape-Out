using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x0200000B RID: 11
	public class PlayerIdPropertyAttribute : PropertyAttribute
	{
		// Token: 0x0600003F RID: 63 RVA: 0x0002D130 File Offset: 0x0002B330
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerIdPropertyAttribute()
		{
			Il2CppClassPointerStore<PlayerIdPropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "PlayerIdPropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerIdPropertyAttribute>.NativeClassPtr);
			PlayerIdPropertyAttribute.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerIdPropertyAttribute>.NativeClassPtr, "HLmDmUQWoPLmPsyHTHuhoXXcGIu");
			PlayerIdPropertyAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerIdPropertyAttribute>.NativeClassPtr, 100663313);
			PlayerIdPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerIdPropertyAttribute>.NativeClassPtr, 100663314);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0002D19C File Offset: 0x0002B39C
		public unsafe Type Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerIdPropertyAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0002D1DC File Offset: 0x0002B3DC
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerIdPropertyAttribute(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerIdPropertyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerIdPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002270 File Offset: 0x00000470
		public PlayerIdPropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0002D228 File Offset: 0x0002B428
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002279 File Offset: 0x00000479
		public unsafe Type HLmDmUQWoPLmPsyHTHuhoXXcGIu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerIdPropertyAttribute.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerIdPropertyAttribute.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}

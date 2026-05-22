using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000069 RID: 105
	public class AnimalSpawner : MonoBehaviour
	{
		// Token: 0x06000E24 RID: 3620 RVA: 0x0005DD20 File Offset: 0x0005BF20
		// Note: this type is marked as 'beforefieldinit'.
		static AnimalSpawner()
		{
			Il2CppClassPointerStore<AnimalSpawner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnimalSpawner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimalSpawner>.NativeClassPtr);
			AnimalSpawner.NativeFieldInfoPtr_door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimalSpawner>.NativeClassPtr, "door");
			AnimalSpawner.NativeFieldInfoPtr_added = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimalSpawner>.NativeClassPtr, "added");
			AnimalSpawner.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSpawner>.NativeClassPtr, 100664500);
			AnimalSpawner.NativeMethodInfoPtr_GetDoor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSpawner>.NativeClassPtr, 100664501);
			AnimalSpawner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSpawner>.NativeClassPtr, 100664502);
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0005DDB4 File Offset: 0x0005BFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44804, XrefRangeEnd = 44891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSpawner.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0005DDE8 File Offset: 0x0005BFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44891, XrefRangeEnd = 44943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSpawner.NativeMethodInfoPtr_GetDoor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0005DE1C File Offset: 0x0005C01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimalSpawner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimalSpawner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSpawner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0000ABA4 File Offset: 0x00008DA4
		public AnimalSpawner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x0005DE58 File Offset: 0x0005C058
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x0000ABAD File Offset: 0x00008DAD
		public unsafe CageDoor door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSpawner.NativeFieldInfoPtr_door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CageDoor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSpawner.NativeFieldInfoPtr_door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x0005DE88 File Offset: 0x0005C088
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x0000ABCC File Offset: 0x00008DCC
		public unsafe bool added
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSpawner.NativeFieldInfoPtr_added);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSpawner.NativeFieldInfoPtr_added)) = value;
			}
		}

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeFieldInfoPtr_door;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeFieldInfoPtr_added;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_GetDoor_Private_Void_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

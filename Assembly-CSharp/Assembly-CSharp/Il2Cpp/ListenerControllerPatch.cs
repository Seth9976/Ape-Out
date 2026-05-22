using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002B RID: 43
	public class ListenerControllerPatch : ScriptableObject
	{
		// Token: 0x0600058E RID: 1422 RVA: 0x000451A0 File Offset: 0x000433A0
		// Note: this type is marked as 'beforefieldinit'.
		static ListenerControllerPatch()
		{
			Il2CppClassPointerStore<ListenerControllerPatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ListenerControllerPatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListenerControllerPatch>.NativeClassPtr);
			ListenerControllerPatch.NativeFieldInfoPtr_WorldVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerControllerPatch>.NativeClassPtr, "WorldVolume");
			ListenerControllerPatch.NativeFieldInfoPtr_MusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerControllerPatch>.NativeClassPtr, "MusicVolume");
			ListenerControllerPatch.NativeFieldInfoPtr_AmbianceVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerControllerPatch>.NativeClassPtr, "AmbianceVolume");
			ListenerControllerPatch.NativeFieldInfoPtr_MasterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerControllerPatch>.NativeClassPtr, "MasterVolume");
			ListenerControllerPatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerControllerPatch>.NativeClassPtr, 100663784);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00045234 File Offset: 0x00043434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListenerControllerPatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListenerControllerPatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerControllerPatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000055BA File Offset: 0x000037BA
		public ListenerControllerPatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00045270 File Offset: 0x00043470
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x000055C3 File Offset: 0x000037C3
		public unsafe float WorldVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerControllerPatch.NativeFieldInfoPtr_WorldVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerControllerPatch.NativeFieldInfoPtr_WorldVolume)) = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00045298 File Offset: 0x00043498
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x000055DE File Offset: 0x000037DE
		public unsafe float MusicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerControllerPatch.NativeFieldInfoPtr_MusicVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerControllerPatch.NativeFieldInfoPtr_MusicVolume)) = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x000452C0 File Offset: 0x000434C0
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x000055F9 File Offset: 0x000037F9
		public unsafe float AmbianceVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerControllerPatch.NativeFieldInfoPtr_AmbianceVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerControllerPatch.NativeFieldInfoPtr_AmbianceVolume)) = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x000452E8 File Offset: 0x000434E8
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00005614 File Offset: 0x00003814
		public unsafe float MasterVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerControllerPatch.NativeFieldInfoPtr_MasterVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerControllerPatch.NativeFieldInfoPtr_MasterVolume)) = value;
			}
		}

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeFieldInfoPtr_WorldVolume;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeFieldInfoPtr_MusicVolume;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeFieldInfoPtr_AmbianceVolume;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeFieldInfoPtr_MasterVolume;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

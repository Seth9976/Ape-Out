using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200000D RID: 13
	[Serializable]
	public class ReverbPatch : ScriptableObject
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x00039388 File Offset: 0x00037588
		// Note: this type is marked as 'beforefieldinit'.
		static ReverbPatch()
		{
			Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ReverbPatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr);
			ReverbPatch.NativeFieldInfoPtr_DryLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr, "DryLevel");
			ReverbPatch.NativeFieldInfoPtr_Room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr, "Room");
			ReverbPatch.NativeFieldInfoPtr_RoomHF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr, "RoomHF");
			ReverbPatch.NativeFieldInfoPtr_DecayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr, "DecayTime");
			ReverbPatch.NativeFieldInfoPtr_DecayHFRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr, "DecayHFRatio");
			ReverbPatch.NativeFieldInfoPtr_Reflections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr, "Reflections");
			ReverbPatch.NativeFieldInfoPtr_ReflectDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr, "ReflectDelay");
			ReverbPatch.NativeFieldInfoPtr_Reverb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr, "Reverb");
			ReverbPatch.NativeFieldInfoPtr_ReverbDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr, "ReverbDelay");
			ReverbPatch.NativeFieldInfoPtr_Diffusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr, "Diffusion");
			ReverbPatch.NativeFieldInfoPtr_Density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr, "Density");
			ReverbPatch.NativeFieldInfoPtr_HFReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr, "HFReference");
			ReverbPatch.NativeFieldInfoPtr_RoomLF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr, "RoomLF");
			ReverbPatch.NativeFieldInfoPtr_LFReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr, "LFReference");
			ReverbPatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr, 100663411);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000394E4 File Offset: 0x000376E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReverbPatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReverbPatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverbPatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000360F File Offset: 0x0000180F
		public ReverbPatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00039520 File Offset: 0x00037720
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00003618 File Offset: 0x00001818
		public unsafe float DryLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_DryLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_DryLevel)) = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00039548 File Offset: 0x00037748
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00003633 File Offset: 0x00001833
		public unsafe float Room
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_Room);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_Room)) = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00039570 File Offset: 0x00037770
		// (set) Token: 0x060001ED RID: 493 RVA: 0x0000364E File Offset: 0x0000184E
		public unsafe float RoomHF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_RoomHF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_RoomHF)) = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00039598 File Offset: 0x00037798
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00003669 File Offset: 0x00001869
		public unsafe float DecayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_DecayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_DecayTime)) = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x000395C0 File Offset: 0x000377C0
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00003684 File Offset: 0x00001884
		public unsafe float DecayHFRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_DecayHFRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_DecayHFRatio)) = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x000395E8 File Offset: 0x000377E8
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0000369F File Offset: 0x0000189F
		public unsafe float Reflections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_Reflections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_Reflections)) = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00039610 File Offset: 0x00037810
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x000036BA File Offset: 0x000018BA
		public unsafe float ReflectDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_ReflectDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_ReflectDelay)) = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00039638 File Offset: 0x00037838
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x000036D5 File Offset: 0x000018D5
		public unsafe float Reverb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_Reverb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_Reverb)) = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00039660 File Offset: 0x00037860
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x000036F0 File Offset: 0x000018F0
		public unsafe float ReverbDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_ReverbDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_ReverbDelay)) = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00039688 File Offset: 0x00037888
		// (set) Token: 0x060001FB RID: 507 RVA: 0x0000370B File Offset: 0x0000190B
		public unsafe float Diffusion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_Diffusion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_Diffusion)) = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001FC RID: 508 RVA: 0x000396B0 File Offset: 0x000378B0
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00003726 File Offset: 0x00001926
		public unsafe float Density
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_Density);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_Density)) = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000396D8 File Offset: 0x000378D8
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00003741 File Offset: 0x00001941
		public unsafe float HFReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_HFReference);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_HFReference)) = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00039700 File Offset: 0x00037900
		// (set) Token: 0x06000201 RID: 513 RVA: 0x0000375C File Offset: 0x0000195C
		public unsafe float RoomLF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_RoomLF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_RoomLF)) = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00039728 File Offset: 0x00037928
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00003777 File Offset: 0x00001977
		public unsafe float LFReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_LFReference);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReverbPatch.NativeFieldInfoPtr_LFReference)) = value;
			}
		}

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_DryLevel;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_Room;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_RoomHF;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_DecayTime;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_DecayHFRatio;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_Reflections;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_ReflectDelay;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_Reverb;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_ReverbDelay;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeFieldInfoPtr_Diffusion;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeFieldInfoPtr_Density;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeFieldInfoPtr_HFReference;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeFieldInfoPtr_RoomLF;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeFieldInfoPtr_LFReference;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

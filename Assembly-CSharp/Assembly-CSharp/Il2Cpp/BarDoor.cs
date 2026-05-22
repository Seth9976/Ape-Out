using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000072 RID: 114
	public class BarDoor : MonoBehaviour
	{
		// Token: 0x06000EAC RID: 3756 RVA: 0x0005F524 File Offset: 0x0005D724
		// Note: this type is marked as 'beforefieldinit'.
		static BarDoor()
		{
			Il2CppClassPointerStore<BarDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BarDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BarDoor>.NativeClassPtr);
			BarDoor.NativeFieldInfoPtr_opening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarDoor>.NativeClassPtr, "opening");
			BarDoor.NativeFieldInfoPtr_openAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarDoor>.NativeClassPtr, "openAmount");
			BarDoor.NativeFieldInfoPtr_openSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarDoor>.NativeClassPtr, "openSpeed");
			BarDoor.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarDoor>.NativeClassPtr, "startPos");
			BarDoor.NativeFieldInfoPtr_played = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarDoor>.NativeClassPtr, "played");
			BarDoor.NativeFieldInfoPtr_obs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarDoor>.NativeClassPtr, "obs");
			BarDoor.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarDoor>.NativeClassPtr, 100664556);
			BarDoor.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarDoor>.NativeClassPtr, 100664557);
			BarDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarDoor>.NativeClassPtr, 100664558);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x0005F608 File Offset: 0x0005D808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45612, XrefRangeEnd = 45619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarDoor.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0005F63C File Offset: 0x0005D83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45619, XrefRangeEnd = 45656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarDoor.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0005F670 File Offset: 0x0005D870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BarDoor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BarDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x0000B06F File Offset: 0x0000926F
		public BarDoor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0005F6AC File Offset: 0x0005D8AC
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x0000B078 File Offset: 0x00009278
		public unsafe bool opening
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarDoor.NativeFieldInfoPtr_opening);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarDoor.NativeFieldInfoPtr_opening)) = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0005F6D4 File Offset: 0x0005D8D4
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x0000B093 File Offset: 0x00009293
		public unsafe float openAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarDoor.NativeFieldInfoPtr_openAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarDoor.NativeFieldInfoPtr_openAmount)) = value;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0005F6FC File Offset: 0x0005D8FC
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x0000B0AE File Offset: 0x000092AE
		public unsafe float openSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarDoor.NativeFieldInfoPtr_openSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarDoor.NativeFieldInfoPtr_openSpeed)) = value;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x0005F724 File Offset: 0x0005D924
		// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x0000B0C9 File Offset: 0x000092C9
		public unsafe Vector2 startPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarDoor.NativeFieldInfoPtr_startPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarDoor.NativeFieldInfoPtr_startPos)) = value;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x0005F74C File Offset: 0x0005D94C
		// (set) Token: 0x06000EBA RID: 3770 RVA: 0x0000B0E4 File Offset: 0x000092E4
		public unsafe bool played
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarDoor.NativeFieldInfoPtr_played);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarDoor.NativeFieldInfoPtr_played)) = value;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x0005F774 File Offset: 0x0005D974
		// (set) Token: 0x06000EBC RID: 3772 RVA: 0x0000B0FF File Offset: 0x000092FF
		public unsafe Obstacle obs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarDoor.NativeFieldInfoPtr_obs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Obstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarDoor.NativeFieldInfoPtr_obs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeFieldInfoPtr_opening;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeFieldInfoPtr_openAmount;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeFieldInfoPtr_openSpeed;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeFieldInfoPtr_startPos;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeFieldInfoPtr_played;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeFieldInfoPtr_obs;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

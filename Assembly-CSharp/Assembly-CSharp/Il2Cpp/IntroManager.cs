using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000111 RID: 273
	public class IntroManager : MonoBehaviour
	{
		// Token: 0x0600206B RID: 8299 RVA: 0x0008F04C File Offset: 0x0008D24C
		// Note: this type is marked as 'beforefieldinit'.
		static IntroManager()
		{
			Il2CppClassPointerStore<IntroManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "IntroManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager>.NativeClassPtr);
			IntroManager.NativeFieldInfoPtr_bunkerIntro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "bunkerIntro");
			IntroManager.NativeFieldInfoPtr_bunkerOutro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "bunkerOutro");
			IntroManager.NativeFieldInfoPtr_labIntro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "labIntro");
			IntroManager.NativeFieldInfoPtr_officeIntro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "officeIntro");
			IntroManager.NativeFieldInfoPtr_zooOutro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "zooOutro");
			IntroManager.NativeFieldInfoPtr_sideTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "sideTitle");
			IntroManager.NativeFieldInfoPtr_boatIntro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "boatIntro");
			IntroManager.NativeFieldInfoPtr_singleIntro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "singleIntro");
			IntroManager.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "me");
			IntroManager.NativeFieldInfoPtr_turnOffWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "turnOffWall");
			IntroManager.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100665858);
			IntroManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100665859);
			IntroManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100665860);
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x0008F180 File Offset: 0x0008D380
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 67735, RefRangeEnd = 67737, XrefRangeStart = 67701, XrefRangeEnd = 67735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x0008F1B4 File Offset: 0x0008D3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67737, XrefRangeEnd = 67767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x0008F1E8 File Offset: 0x0008D3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntroManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x00016AAD File Offset: 0x00014CAD
		public IntroManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x0008F224 File Offset: 0x0008D424
		// (set) Token: 0x06002071 RID: 8305 RVA: 0x00016AB6 File Offset: 0x00014CB6
		public unsafe GameObject bunkerIntro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_bunkerIntro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_bunkerIntro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x0008F254 File Offset: 0x0008D454
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x00016AD5 File Offset: 0x00014CD5
		public unsafe GameObject bunkerOutro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_bunkerOutro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_bunkerOutro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x0008F284 File Offset: 0x0008D484
		// (set) Token: 0x06002075 RID: 8309 RVA: 0x00016AF4 File Offset: 0x00014CF4
		public unsafe GameObject labIntro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_labIntro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_labIntro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x0008F2B4 File Offset: 0x0008D4B4
		// (set) Token: 0x06002077 RID: 8311 RVA: 0x00016B13 File Offset: 0x00014D13
		public unsafe GameObject officeIntro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_officeIntro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_officeIntro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x0008F2E4 File Offset: 0x0008D4E4
		// (set) Token: 0x06002079 RID: 8313 RVA: 0x00016B32 File Offset: 0x00014D32
		public unsafe GameObject zooOutro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_zooOutro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_zooOutro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x0008F314 File Offset: 0x0008D514
		// (set) Token: 0x0600207B RID: 8315 RVA: 0x00016B51 File Offset: 0x00014D51
		public unsafe GameObject sideTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_sideTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_sideTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x0008F344 File Offset: 0x0008D544
		// (set) Token: 0x0600207D RID: 8317 RVA: 0x00016B70 File Offset: 0x00014D70
		public unsafe GameObject boatIntro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_boatIntro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_boatIntro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x0600207E RID: 8318 RVA: 0x0008F374 File Offset: 0x0008D574
		// (set) Token: 0x0600207F RID: 8319 RVA: 0x00016B8F File Offset: 0x00014D8F
		public unsafe GameObject singleIntro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_singleIntro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_singleIntro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06002080 RID: 8320 RVA: 0x0008F3A4 File Offset: 0x0008D5A4
		// (set) Token: 0x06002081 RID: 8321 RVA: 0x00016BAE File Offset: 0x00014DAE
		public unsafe static IntroManager me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IntroManager.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntroManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntroManager.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06002082 RID: 8322 RVA: 0x0008F3CC File Offset: 0x0008D5CC
		// (set) Token: 0x06002083 RID: 8323 RVA: 0x00016BC0 File Offset: 0x00014DC0
		public unsafe bool turnOffWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_turnOffWall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_turnOffWall)) = value;
			}
		}

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeFieldInfoPtr_bunkerIntro;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeFieldInfoPtr_bunkerOutro;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeFieldInfoPtr_labIntro;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeFieldInfoPtr_officeIntro;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeFieldInfoPtr_zooOutro;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeFieldInfoPtr_sideTitle;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeFieldInfoPtr_boatIntro;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeFieldInfoPtr_singleIntro;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeFieldInfoPtr_turnOffWall;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

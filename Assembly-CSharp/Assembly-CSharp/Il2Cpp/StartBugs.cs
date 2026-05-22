using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001A7 RID: 423
	public class StartBugs : MonoBehaviour
	{
		// Token: 0x0600308B RID: 12427 RVA: 0x000B9E2C File Offset: 0x000B802C
		// Note: this type is marked as 'beforefieldinit'.
		static StartBugs()
		{
			Il2CppClassPointerStore<StartBugs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StartBugs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartBugs>.NativeClassPtr);
			StartBugs.NativeFieldInfoPtr_pSys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartBugs>.NativeClassPtr, "pSys");
			StartBugs.NativeFieldInfoPtr_played = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartBugs>.NativeClassPtr, "played");
			StartBugs.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartBugs>.NativeClassPtr, 100667090);
			StartBugs.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartBugs>.NativeClassPtr, 100667091);
			StartBugs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartBugs>.NativeClassPtr, 100667092);
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x000B9EC0 File Offset: 0x000B80C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84538, XrefRangeEnd = 84541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartBugs.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x000B9EF4 File Offset: 0x000B80F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84541, XrefRangeEnd = 84543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartBugs.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x000B9F38 File Offset: 0x000B8138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartBugs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartBugs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartBugs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x0002165D File Offset: 0x0001F85D
		public StartBugs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x06003090 RID: 12432 RVA: 0x000B9F74 File Offset: 0x000B8174
		// (set) Token: 0x06003091 RID: 12433 RVA: 0x00021666 File Offset: 0x0001F866
		public unsafe ParticleSystem pSys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartBugs.NativeFieldInfoPtr_pSys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartBugs.NativeFieldInfoPtr_pSys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06003092 RID: 12434 RVA: 0x000B9FA4 File Offset: 0x000B81A4
		// (set) Token: 0x06003093 RID: 12435 RVA: 0x00021685 File Offset: 0x0001F885
		public unsafe bool played
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartBugs.NativeFieldInfoPtr_played);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartBugs.NativeFieldInfoPtr_played)) = value;
			}
		}

		// Token: 0x04001C81 RID: 7297
		private static readonly IntPtr NativeFieldInfoPtr_pSys;

		// Token: 0x04001C82 RID: 7298
		private static readonly IntPtr NativeFieldInfoPtr_played;

		// Token: 0x04001C83 RID: 7299
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001C84 RID: 7300
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;

		// Token: 0x04001C85 RID: 7301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

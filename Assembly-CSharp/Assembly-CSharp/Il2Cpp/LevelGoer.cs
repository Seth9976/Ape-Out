using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200011D RID: 285
	public class LevelGoer : MonoBehaviour
	{
		// Token: 0x06002279 RID: 8825 RVA: 0x00094088 File Offset: 0x00092288
		// Note: this type is marked as 'beforefieldinit'.
		static LevelGoer()
		{
			Il2CppClassPointerStore<LevelGoer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LevelGoer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelGoer>.NativeClassPtr);
			LevelGoer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelGoer>.NativeClassPtr, "text");
			LevelGoer.NativeFieldInfoPtr_lab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelGoer>.NativeClassPtr, "lab");
			LevelGoer.NativeFieldInfoPtr_office = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelGoer>.NativeClassPtr, "office");
			LevelGoer.NativeFieldInfoPtr_bunker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelGoer>.NativeClassPtr, "bunker");
			LevelGoer.NativeFieldInfoPtr_boat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelGoer>.NativeClassPtr, "boat");
			LevelGoer.NativeFieldInfoPtr_langCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelGoer>.NativeClassPtr, "langCode");
			LevelGoer.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelGoer>.NativeClassPtr, 100665966);
			LevelGoer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelGoer>.NativeClassPtr, 100665967);
			LevelGoer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelGoer>.NativeClassPtr, 100665968);
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x0009416C File Offset: 0x0009236C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69156, XrefRangeEnd = 69185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelGoer.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x000941A0 File Offset: 0x000923A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69185, XrefRangeEnd = 69198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelGoer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x000941D4 File Offset: 0x000923D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69198, XrefRangeEnd = 69372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LevelGoer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelGoer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelGoer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x00018370 File Offset: 0x00016570
		public LevelGoer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x0600227E RID: 8830 RVA: 0x00094210 File Offset: 0x00092410
		// (set) Token: 0x0600227F RID: 8831 RVA: 0x00018379 File Offset: 0x00016579
		public unsafe TextMesh text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelGoer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelGoer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06002280 RID: 8832 RVA: 0x00094240 File Offset: 0x00092440
		// (set) Token: 0x06002281 RID: 8833 RVA: 0x00018398 File Offset: 0x00016598
		public unsafe Il2CppStringArray lab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelGoer.NativeFieldInfoPtr_lab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelGoer.NativeFieldInfoPtr_lab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06002282 RID: 8834 RVA: 0x00094270 File Offset: 0x00092470
		// (set) Token: 0x06002283 RID: 8835 RVA: 0x000183B7 File Offset: 0x000165B7
		public unsafe Il2CppStringArray office
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelGoer.NativeFieldInfoPtr_office);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelGoer.NativeFieldInfoPtr_office), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06002284 RID: 8836 RVA: 0x000942A0 File Offset: 0x000924A0
		// (set) Token: 0x06002285 RID: 8837 RVA: 0x000183D6 File Offset: 0x000165D6
		public unsafe Il2CppStringArray bunker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelGoer.NativeFieldInfoPtr_bunker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelGoer.NativeFieldInfoPtr_bunker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x000942D0 File Offset: 0x000924D0
		// (set) Token: 0x06002287 RID: 8839 RVA: 0x000183F5 File Offset: 0x000165F5
		public unsafe Il2CppStringArray boat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelGoer.NativeFieldInfoPtr_boat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelGoer.NativeFieldInfoPtr_boat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x00094300 File Offset: 0x00092500
		// (set) Token: 0x06002289 RID: 8841 RVA: 0x00018414 File Offset: 0x00016614
		public unsafe string langCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelGoer.NativeFieldInfoPtr_langCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelGoer.NativeFieldInfoPtr_langCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeFieldInfoPtr_lab;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeFieldInfoPtr_office;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeFieldInfoPtr_bunker;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeFieldInfoPtr_boat;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeFieldInfoPtr_langCode;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

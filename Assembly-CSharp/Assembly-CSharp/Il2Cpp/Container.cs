using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000AB RID: 171
	public class Container : MonoBehaviour
	{
		// Token: 0x060014C1 RID: 5313 RVA: 0x0006F2F4 File Offset: 0x0006D4F4
		// Note: this type is marked as 'beforefieldinit'.
		static Container()
		{
			Il2CppClassPointerStore<Container>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Container");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Container>.NativeClassPtr);
			Container.NativeFieldInfoPtr_topper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Container>.NativeClassPtr, "topper");
			Container.NativeFieldInfoPtr_topperPal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Container>.NativeClassPtr, "topperPal");
			Container.NativeFieldInfoPtr_transpMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Container>.NativeClassPtr, "transpMat");
			Container.NativeFieldInfoPtr_defMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Container>.NativeClassPtr, "defMat");
			Container.NativeFieldInfoPtr_pinToRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Container>.NativeClassPtr, "pinToRend");
			Container.NativeFieldInfoPtr_renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Container>.NativeClassPtr, "renderers");
			Container.NativeFieldInfoPtr_hardCodedMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Container>.NativeClassPtr, "hardCodedMat");
			Container.NativeFieldInfoPtr_sideRends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Container>.NativeClassPtr, "sideRends");
			Container.NativeFieldInfoPtr_broughtUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Container>.NativeClassPtr, "broughtUp");
			Container.NativeFieldInfoPtr_foreground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Container>.NativeClassPtr, "foreground");
			Container.NativeFieldInfoPtr_defLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Container>.NativeClassPtr, "defLayer");
			Container.NativeFieldInfoPtr_defPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Container>.NativeClassPtr, "defPos");
			Container.NativeFieldInfoPtr_dontMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Container>.NativeClassPtr, "dontMusic");
			Container.NativeFieldInfoPtr_playerInContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Container>.NativeClassPtr, "playerInContainer");
			Container.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Container>.NativeClassPtr, 100665056);
			Container.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Container>.NativeClassPtr, 100665057);
			Container.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Container>.NativeClassPtr, 100665058);
			Container.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Container>.NativeClassPtr, 100665059);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0006F48C File Offset: 0x0006D68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52855, XrefRangeEnd = 52888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Container.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0006F4C0 File Offset: 0x0006D6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52888, XrefRangeEnd = 52973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Container.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0006F4F4 File Offset: 0x0006D6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52973, XrefRangeEnd = 53044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Container.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0006F528 File Offset: 0x0006D728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Container()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Container>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Container.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0000F101 File Offset: 0x0000D301
		public Container(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x0006F564 File Offset: 0x0006D764
		// (set) Token: 0x060014C8 RID: 5320 RVA: 0x0000F10A File Offset: 0x0000D30A
		public unsafe MeshRenderer topper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_topper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_topper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x0006F594 File Offset: 0x0006D794
		// (set) Token: 0x060014CA RID: 5322 RVA: 0x0000F129 File Offset: 0x0000D329
		public unsafe MeshRenderer topperPal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_topperPal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_topperPal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x0006F5C4 File Offset: 0x0006D7C4
		// (set) Token: 0x060014CC RID: 5324 RVA: 0x0000F148 File Offset: 0x0000D348
		public unsafe Material transpMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_transpMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_transpMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x0006F5F4 File Offset: 0x0006D7F4
		// (set) Token: 0x060014CE RID: 5326 RVA: 0x0000F167 File Offset: 0x0000D367
		public unsafe Material defMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_defMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_defMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x0006F624 File Offset: 0x0006D824
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x0000F186 File Offset: 0x0000D386
		public unsafe Il2CppReferenceArray<MeshRenderer> pinToRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_pinToRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_pinToRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x0006F654 File Offset: 0x0006D854
		// (set) Token: 0x060014D2 RID: 5330 RVA: 0x0000F1A5 File Offset: 0x0000D3A5
		public unsafe Il2CppReferenceArray<Renderer> renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x0006F684 File Offset: 0x0006D884
		// (set) Token: 0x060014D4 RID: 5332 RVA: 0x0000F1C4 File Offset: 0x0000D3C4
		public unsafe Material hardCodedMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_hardCodedMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_hardCodedMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x0006F6B4 File Offset: 0x0006D8B4
		// (set) Token: 0x060014D6 RID: 5334 RVA: 0x0000F1E3 File Offset: 0x0000D3E3
		public unsafe Il2CppReferenceArray<MeshRenderer> sideRends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_sideRends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_sideRends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x0006F6E4 File Offset: 0x0006D8E4
		// (set) Token: 0x060014D8 RID: 5336 RVA: 0x0000F202 File Offset: 0x0000D402
		public unsafe bool broughtUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_broughtUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_broughtUp)) = value;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x0006F70C File Offset: 0x0006D90C
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x0000F21D File Offset: 0x0000D41D
		public unsafe int foreground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_foreground);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_foreground)) = value;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x0006F734 File Offset: 0x0006D934
		// (set) Token: 0x060014DC RID: 5340 RVA: 0x0000F238 File Offset: 0x0000D438
		public unsafe int defLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_defLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_defLayer)) = value;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x0006F75C File Offset: 0x0006D95C
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x0000F253 File Offset: 0x0000D453
		public unsafe Vector2 defPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_defPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_defPos)) = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x0006F784 File Offset: 0x0006D984
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x0000F26E File Offset: 0x0000D46E
		public unsafe bool dontMusic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_dontMusic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_dontMusic)) = value;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x0006F7AC File Offset: 0x0006D9AC
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x0000F289 File Offset: 0x0000D489
		public unsafe bool playerInContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_playerInContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Container.NativeFieldInfoPtr_playerInContainer)) = value;
			}
		}

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeFieldInfoPtr_topper;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeFieldInfoPtr_topperPal;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeFieldInfoPtr_transpMat;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeFieldInfoPtr_defMat;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeFieldInfoPtr_pinToRend;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeFieldInfoPtr_renderers;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeFieldInfoPtr_hardCodedMat;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeFieldInfoPtr_sideRends;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeFieldInfoPtr_broughtUp;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeFieldInfoPtr_foreground;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeFieldInfoPtr_defLayer;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeFieldInfoPtr_defPos;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeFieldInfoPtr_dontMusic;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeFieldInfoPtr_playerInContainer;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

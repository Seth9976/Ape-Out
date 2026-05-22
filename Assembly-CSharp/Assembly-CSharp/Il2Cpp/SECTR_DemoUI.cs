using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000056 RID: 86
	public class SECTR_DemoUI : MonoBehaviour
	{
		// Token: 0x06000C85 RID: 3205 RVA: 0x00059DC0 File Offset: 0x00057FC0
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_DemoUI()
		{
			Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_DemoUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr);
			SECTR_DemoUI.NativeFieldInfoPtr_passedIntro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, "passedIntro");
			SECTR_DemoUI.NativeFieldInfoPtr_cachedController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, "cachedController");
			SECTR_DemoUI.NativeFieldInfoPtr_demoButtonStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, "demoButtonStyle");
			SECTR_DemoUI.NativeFieldInfoPtr_watermarkLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, "watermarkLocation");
			SECTR_DemoUI.NativeFieldInfoPtr_demoButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, "demoButtons");
			SECTR_DemoUI.NativeFieldInfoPtr_Watermark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, "Watermark");
			SECTR_DemoUI.NativeFieldInfoPtr_PipController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, "PipController");
			SECTR_DemoUI.NativeFieldInfoPtr_DemoMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, "DemoMessage");
			SECTR_DemoUI.NativeFieldInfoPtr_CaptureMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, "CaptureMode");
			SECTR_DemoUI.NativeMethodInfoPtr_get_PipActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, 100664407);
			SECTR_DemoUI.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, 100664408);
			SECTR_DemoUI.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, 100664409);
			SECTR_DemoUI.NativeMethodInfoPtr_OnGUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, 100664410);
			SECTR_DemoUI.NativeMethodInfoPtr_AddButton_Protected_Void_KeyCode_String_String_DemoButtonPressedDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, 100664411);
			SECTR_DemoUI.NativeMethodInfoPtr_PressedPip_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, 100664412);
			SECTR_DemoUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, 100664413);
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00059F30 File Offset: 0x00058130
		public unsafe bool PipActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43015, XrefRangeEnd = 43019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DemoUI.NativeMethodInfoPtr_get_PipActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00059F6C File Offset: 0x0005816C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43047, RefRangeEnd = 43048, XrefRangeStart = 43019, XrefRangeEnd = 43047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_DemoUI.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00059FA8 File Offset: 0x000581A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43048, XrefRangeEnd = 43056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_DemoUI.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00059FE4 File Offset: 0x000581E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43056, XrefRangeEnd = 43144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_DemoUI.NativeMethodInfoPtr_OnGUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0005A020 File Offset: 0x00058220
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 43152, RefRangeEnd = 43159, XrefRangeStart = 43144, XrefRangeEnd = 43152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddButton(KeyCode key, string activeHint, string inactiveHint, SECTR_DemoUI.DemoButtonPressedDelegate buttonPressedDelegate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activeHint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(inactiveHint);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttonPressedDelegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DemoUI.NativeMethodInfoPtr_AddButton_Protected_Void_KeyCode_String_String_DemoButtonPressedDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0005A098 File Offset: 0x00058298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43159, XrefRangeEnd = 43184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PressedPip(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DemoUI.NativeMethodInfoPtr_PressedPip_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0005A0D8 File Offset: 0x000582D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43184, XrefRangeEnd = 43195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_DemoUI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DemoUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00009973 File Offset: 0x00007B73
		public SECTR_DemoUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x0005A114 File Offset: 0x00058314
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x0000997C File Offset: 0x00007B7C
		public unsafe bool passedIntro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_passedIntro);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_passedIntro)) = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x0005A13C File Offset: 0x0005833C
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00009997 File Offset: 0x00007B97
		public unsafe SECTR_FPSController cachedController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_cachedController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_FPSController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_cachedController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x0005A16C File Offset: 0x0005836C
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x000099B6 File Offset: 0x00007BB6
		public unsafe GUIStyle demoButtonStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_demoButtonStyle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_demoButtonStyle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x0005A19C File Offset: 0x0005839C
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x000099D5 File Offset: 0x00007BD5
		public unsafe SECTR_DemoUI.WatermarkLocation watermarkLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_watermarkLocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_watermarkLocation)) = value;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x0005A1C4 File Offset: 0x000583C4
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x000099F0 File Offset: 0x00007BF0
		public unsafe List<SECTR_DemoUI.DemoButton> demoButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_demoButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_DemoUI.DemoButton>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_demoButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x0005A1F4 File Offset: 0x000583F4
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x00009A0F File Offset: 0x00007C0F
		public unsafe Texture2D Watermark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_Watermark);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_Watermark), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x0005A224 File Offset: 0x00058424
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x00009A2E File Offset: 0x00007C2E
		public unsafe SECTR_GhostController PipController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_PipController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_GhostController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_PipController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x0005A254 File Offset: 0x00058454
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x00009A4D File Offset: 0x00007C4D
		public unsafe string DemoMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_DemoMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_DemoMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x0005A27C File Offset: 0x0005847C
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x00009A6C File Offset: 0x00007C6C
		public unsafe bool CaptureMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_CaptureMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.NativeFieldInfoPtr_CaptureMode)) = value;
			}
		}

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeFieldInfoPtr_passedIntro;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeFieldInfoPtr_cachedController;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeFieldInfoPtr_demoButtonStyle;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeFieldInfoPtr_watermarkLocation;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeFieldInfoPtr_demoButtons;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeFieldInfoPtr_Watermark;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeFieldInfoPtr_PipController;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeFieldInfoPtr_DemoMessage;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeFieldInfoPtr_CaptureMode;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_get_PipActive_Public_get_Boolean_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Protected_Virtual_New_Void_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_AddButton_Protected_Void_KeyCode_String_String_DemoButtonPressedDelegate_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr_PressedPip_Private_Void_Boolean_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002CB RID: 715
		[OriginalName("Assembly-CSharp.dll", "", "WatermarkLocation")]
		public enum WatermarkLocation
		{
			// Token: 0x04003225 RID: 12837
			UpperLeft,
			// Token: 0x04003226 RID: 12838
			UpperCenter,
			// Token: 0x04003227 RID: 12839
			UpperRight
		}

		// Token: 0x020002CC RID: 716
		public sealed class DemoButtonPressedDelegate : MulticastDelegate
		{
			// Token: 0x06004C8D RID: 19597 RVA: 0x00119B28 File Offset: 0x00117D28
			// Note: this type is marked as 'beforefieldinit'.
			static DemoButtonPressedDelegate()
			{
				Il2CppClassPointerStore<SECTR_DemoUI.DemoButtonPressedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, "DemoButtonPressedDelegate");
				SECTR_DemoUI.DemoButtonPressedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DemoUI.DemoButtonPressedDelegate>.NativeClassPtr, 100664414);
				SECTR_DemoUI.DemoButtonPressedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DemoUI.DemoButtonPressedDelegate>.NativeClassPtr, 100664415);
				SECTR_DemoUI.DemoButtonPressedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DemoUI.DemoButtonPressedDelegate>.NativeClassPtr, 100664416);
				SECTR_DemoUI.DemoButtonPressedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DemoUI.DemoButtonPressedDelegate>.NativeClassPtr, 100664417);
			}

			// Token: 0x06004C8E RID: 19598 RVA: 0x00119B9C File Offset: 0x00117D9C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DemoButtonPressedDelegate(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_DemoUI.DemoButtonPressedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DemoUI.DemoButtonPressedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C8F RID: 19599 RVA: 0x00119BF8 File Offset: 0x00117DF8
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 42994, RefRangeEnd = 43010, XrefRangeStart = 42994, XrefRangeEnd = 42994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(bool active)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref active;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DemoUI.DemoButtonPressedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004C90 RID: 19600 RVA: 0x00119C38 File Offset: 0x00117E38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43010, XrefRangeEnd = 43014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(bool active, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref active;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DemoUI.DemoButtonPressedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004C91 RID: 19601 RVA: 0x00119CA8 File Offset: 0x00117EA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DemoUI.DemoButtonPressedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004C92 RID: 19602 RVA: 0x0002D187 File Offset: 0x0002B387
			public DemoButtonPressedDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004C93 RID: 19603 RVA: 0x0002D190 File Offset: 0x0002B390
			public static implicit operator SECTR_DemoUI.DemoButtonPressedDelegate(Action<bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<SECTR_DemoUI.DemoButtonPressedDelegate>(A_0);
			}

			// Token: 0x06004C94 RID: 19604 RVA: 0x0002D198 File Offset: 0x0002B398
			public static SECTR_DemoUI.DemoButtonPressedDelegate operator +(SECTR_DemoUI.DemoButtonPressedDelegate A_0, SECTR_DemoUI.DemoButtonPressedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SECTR_DemoUI.DemoButtonPressedDelegate>();
			}

			// Token: 0x06004C95 RID: 19605 RVA: 0x0002D1A6 File Offset: 0x0002B3A6
			public static SECTR_DemoUI.DemoButtonPressedDelegate operator -(SECTR_DemoUI.DemoButtonPressedDelegate A_0, SECTR_DemoUI.DemoButtonPressedDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<SECTR_DemoUI.DemoButtonPressedDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04003228 RID: 12840
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003229 RID: 12841
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;

			// Token: 0x0400322A RID: 12842
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

			// Token: 0x0400322B RID: 12843
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020002CD RID: 717
		public class DemoButton : global::Il2CppSystem.Object
		{
			// Token: 0x06004C96 RID: 19606 RVA: 0x00119CEC File Offset: 0x00117EEC
			// Note: this type is marked as 'beforefieldinit'.
			static DemoButton()
			{
				Il2CppClassPointerStore<SECTR_DemoUI.DemoButton>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_DemoUI>.NativeClassPtr, "DemoButton");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_DemoUI.DemoButton>.NativeClassPtr);
				SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DemoUI.DemoButton>.NativeClassPtr, "key");
				SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_activeHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DemoUI.DemoButton>.NativeClassPtr, "activeHint");
				SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_inactiveHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DemoUI.DemoButton>.NativeClassPtr, "inactiveHint");
				SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DemoUI.DemoButton>.NativeClassPtr, "active");
				SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_pressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DemoUI.DemoButton>.NativeClassPtr, "pressed");
				SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_demoButtonPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_DemoUI.DemoButton>.NativeClassPtr, "demoButtonPressed");
				SECTR_DemoUI.DemoButton.NativeMethodInfoPtr__ctor_Public_Void_KeyCode_String_String_DemoButtonPressedDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_DemoUI.DemoButton>.NativeClassPtr, 100664418);
			}

			// Token: 0x06004C97 RID: 19607 RVA: 0x00119DA4 File Offset: 0x00117FA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43014, XrefRangeEnd = 43015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DemoButton(KeyCode key, string activeHint, string inactiveHint, SECTR_DemoUI.DemoButtonPressedDelegate demoButtonPressed)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_DemoUI.DemoButton>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activeHint);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(inactiveHint);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(demoButtonPressed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_DemoUI.DemoButton.NativeMethodInfoPtr__ctor_Public_Void_KeyCode_String_String_DemoButtonPressedDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C98 RID: 19608 RVA: 0x0002D1B7 File Offset: 0x0002B3B7
			public DemoButton(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BE6 RID: 7142
			// (get) Token: 0x06004C99 RID: 19609 RVA: 0x00119E24 File Offset: 0x00118024
			// (set) Token: 0x06004C9A RID: 19610 RVA: 0x0002D1C0 File Offset: 0x0002B3C0
			public unsafe KeyCode key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_key);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_key)) = value;
				}
			}

			// Token: 0x17001BE7 RID: 7143
			// (get) Token: 0x06004C9B RID: 19611 RVA: 0x00119E4C File Offset: 0x0011804C
			// (set) Token: 0x06004C9C RID: 19612 RVA: 0x0002D1DB File Offset: 0x0002B3DB
			public unsafe string activeHint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_activeHint);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_activeHint), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001BE8 RID: 7144
			// (get) Token: 0x06004C9D RID: 19613 RVA: 0x00119E74 File Offset: 0x00118074
			// (set) Token: 0x06004C9E RID: 19614 RVA: 0x0002D1FA File Offset: 0x0002B3FA
			public unsafe string inactiveHint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_inactiveHint);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_inactiveHint), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001BE9 RID: 7145
			// (get) Token: 0x06004C9F RID: 19615 RVA: 0x00119E9C File Offset: 0x0011809C
			// (set) Token: 0x06004CA0 RID: 19616 RVA: 0x0002D219 File Offset: 0x0002B419
			public unsafe bool active
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_active)) = value;
				}
			}

			// Token: 0x17001BEA RID: 7146
			// (get) Token: 0x06004CA1 RID: 19617 RVA: 0x00119EC4 File Offset: 0x001180C4
			// (set) Token: 0x06004CA2 RID: 19618 RVA: 0x0002D234 File Offset: 0x0002B434
			public unsafe bool pressed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_pressed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_pressed)) = value;
				}
			}

			// Token: 0x17001BEB RID: 7147
			// (get) Token: 0x06004CA3 RID: 19619 RVA: 0x00119EEC File Offset: 0x001180EC
			// (set) Token: 0x06004CA4 RID: 19620 RVA: 0x0002D24F File Offset: 0x0002B44F
			public unsafe SECTR_DemoUI.DemoButtonPressedDelegate demoButtonPressed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_demoButtonPressed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_DemoUI.DemoButtonPressedDelegate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_DemoUI.DemoButton.NativeFieldInfoPtr_demoButtonPressed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400322C RID: 12844
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400322D RID: 12845
			private static readonly IntPtr NativeFieldInfoPtr_activeHint;

			// Token: 0x0400322E RID: 12846
			private static readonly IntPtr NativeFieldInfoPtr_inactiveHint;

			// Token: 0x0400322F RID: 12847
			private static readonly IntPtr NativeFieldInfoPtr_active;

			// Token: 0x04003230 RID: 12848
			private static readonly IntPtr NativeFieldInfoPtr_pressed;

			// Token: 0x04003231 RID: 12849
			private static readonly IntPtr NativeFieldInfoPtr_demoButtonPressed;

			// Token: 0x04003232 RID: 12850
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_KeyCode_String_String_DemoButtonPressedDelegate_0;
		}
	}
}

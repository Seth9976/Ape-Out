using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000057 RID: 87
	public class SECTR_FPController : MonoBehaviour
	{
		// Token: 0x06000CA0 RID: 3232 RVA: 0x0005A2A4 File Offset: 0x000584A4
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_FPController()
		{
			Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_FPController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr);
			SECTR_FPController.NativeFieldInfoPtr__mouseAbsolute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, "_mouseAbsolute");
			SECTR_FPController.NativeFieldInfoPtr__smoothMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, "_smoothMouse");
			SECTR_FPController.NativeFieldInfoPtr__clampInDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, "_clampInDegrees");
			SECTR_FPController.NativeFieldInfoPtr__targetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, "_targetDirection");
			SECTR_FPController.NativeFieldInfoPtr_focused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, "focused");
			SECTR_FPController.NativeFieldInfoPtr__touches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, "_touches");
			SECTR_FPController.NativeFieldInfoPtr_LockCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, "LockCursor");
			SECTR_FPController.NativeFieldInfoPtr_Sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, "Sensitivity");
			SECTR_FPController.NativeFieldInfoPtr_Smoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, "Smoothing");
			SECTR_FPController.NativeFieldInfoPtr_TouchScreenLookScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, "TouchScreenLookScale");
			SECTR_FPController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, 100664419);
			SECTR_FPController.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, 100664420);
			SECTR_FPController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, 100664421);
			SECTR_FPController.NativeMethodInfoPtr_GetScreenJoystick_Protected_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, 100664422);
			SECTR_FPController.NativeMethodInfoPtr__UpdateTouches_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, 100664423);
			SECTR_FPController.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, 100664424);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0005A414 File Offset: 0x00058614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43195, XrefRangeEnd = 43200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_FPController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0005A448 File Offset: 0x00058648
		[CallerCount(0)]
		public unsafe void OnApplicationFocus(bool focused)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref focused;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_FPController.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0005A488 File Offset: 0x00058688
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43257, RefRangeEnd = 43259, XrefRangeStart = 43200, XrefRangeEnd = 43257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_FPController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0005A4C4 File Offset: 0x000586C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43276, RefRangeEnd = 43279, XrefRangeStart = 43259, XrefRangeEnd = 43276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetScreenJoystick(bool left)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_FPController.NativeMethodInfoPtr_GetScreenJoystick_Protected_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0005A510 File Offset: 0x00058710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43317, RefRangeEnd = 43318, XrefRangeStart = 43279, XrefRangeEnd = 43317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateTouches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_FPController.NativeMethodInfoPtr__UpdateTouches_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0005A544 File Offset: 0x00058744
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43326, RefRangeEnd = 43328, XrefRangeStart = 43318, XrefRangeEnd = 43326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_FPController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_FPController.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00009A87 File Offset: 0x00007C87
		public SECTR_FPController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x0005A580 File Offset: 0x00058780
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x00009A90 File Offset: 0x00007C90
		public unsafe Vector2 _mouseAbsolute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr__mouseAbsolute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr__mouseAbsolute)) = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x0005A5A8 File Offset: 0x000587A8
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x00009AAB File Offset: 0x00007CAB
		public unsafe Vector2 _smoothMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr__smoothMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr__smoothMouse)) = value;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x0005A5D0 File Offset: 0x000587D0
		// (set) Token: 0x06000CAD RID: 3245 RVA: 0x00009AC6 File Offset: 0x00007CC6
		public unsafe Vector2 _clampInDegrees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr__clampInDegrees);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr__clampInDegrees)) = value;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x0005A5F8 File Offset: 0x000587F8
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x00009AE1 File Offset: 0x00007CE1
		public unsafe Vector2 _targetDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr__targetDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr__targetDirection)) = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x0005A620 File Offset: 0x00058820
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x00009AFC File Offset: 0x00007CFC
		public unsafe bool focused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr_focused);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr_focused)) = value;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x0005A648 File Offset: 0x00058848
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x00009B17 File Offset: 0x00007D17
		public unsafe Dictionary<int, SECTR_FPController.TrackedTouch> _touches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr__touches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SECTR_FPController.TrackedTouch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr__touches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x0005A678 File Offset: 0x00058878
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x00009B36 File Offset: 0x00007D36
		public unsafe bool LockCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr_LockCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr_LockCursor)) = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0005A6A0 File Offset: 0x000588A0
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00009B51 File Offset: 0x00007D51
		public unsafe Vector2 Sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr_Sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr_Sensitivity)) = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x0005A6C8 File Offset: 0x000588C8
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x00009B6C File Offset: 0x00007D6C
		public unsafe Vector2 Smoothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr_Smoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr_Smoothing)) = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0005A6F0 File Offset: 0x000588F0
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x00009B87 File Offset: 0x00007D87
		public unsafe float TouchScreenLookScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr_TouchScreenLookScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.NativeFieldInfoPtr_TouchScreenLookScale)) = value;
			}
		}

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr__mouseAbsolute;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr__smoothMouse;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeFieldInfoPtr__clampInDegrees;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeFieldInfoPtr__targetDirection;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeFieldInfoPtr_focused;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeFieldInfoPtr__touches;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeFieldInfoPtr_LockCursor;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeFieldInfoPtr_Sensitivity;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeFieldInfoPtr_Smoothing;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeFieldInfoPtr_TouchScreenLookScale;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenJoystick_Protected_Vector2_Boolean_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr__UpdateTouches_Private_Void_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020002CE RID: 718
		public class TrackedTouch : global::Il2CppSystem.Object
		{
			// Token: 0x06004CA5 RID: 19621 RVA: 0x00119F1C File Offset: 0x0011811C
			// Note: this type is marked as 'beforefieldinit'.
			static TrackedTouch()
			{
				Il2CppClassPointerStore<SECTR_FPController.TrackedTouch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_FPController>.NativeClassPtr, "TrackedTouch");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_FPController.TrackedTouch>.NativeClassPtr);
				SECTR_FPController.TrackedTouch.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_FPController.TrackedTouch>.NativeClassPtr, "startPos");
				SECTR_FPController.TrackedTouch.NativeFieldInfoPtr_currentPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_FPController.TrackedTouch>.NativeClassPtr, "currentPos");
				SECTR_FPController.TrackedTouch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_FPController.TrackedTouch>.NativeClassPtr, 100664425);
			}

			// Token: 0x06004CA6 RID: 19622 RVA: 0x00119F84 File Offset: 0x00118184
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TrackedTouch()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_FPController.TrackedTouch>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_FPController.TrackedTouch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CA7 RID: 19623 RVA: 0x0002D26E File Offset: 0x0002B46E
			public TrackedTouch(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BEC RID: 7148
			// (get) Token: 0x06004CA8 RID: 19624 RVA: 0x00119FC0 File Offset: 0x001181C0
			// (set) Token: 0x06004CA9 RID: 19625 RVA: 0x0002D277 File Offset: 0x0002B477
			public unsafe Vector2 startPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.TrackedTouch.NativeFieldInfoPtr_startPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.TrackedTouch.NativeFieldInfoPtr_startPos)) = value;
				}
			}

			// Token: 0x17001BED RID: 7149
			// (get) Token: 0x06004CAA RID: 19626 RVA: 0x00119FE8 File Offset: 0x001181E8
			// (set) Token: 0x06004CAB RID: 19627 RVA: 0x0002D292 File Offset: 0x0002B492
			public unsafe Vector2 currentPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.TrackedTouch.NativeFieldInfoPtr_currentPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_FPController.TrackedTouch.NativeFieldInfoPtr_currentPos)) = value;
				}
			}

			// Token: 0x04003233 RID: 12851
			private static readonly IntPtr NativeFieldInfoPtr_startPos;

			// Token: 0x04003234 RID: 12852
			private static readonly IntPtr NativeFieldInfoPtr_currentPos;

			// Token: 0x04003235 RID: 12853
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

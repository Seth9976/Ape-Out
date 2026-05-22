using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public class SendMouseEvents : Object
	{
		// Token: 0x0600006A RID: 106 RVA: 0x000038AC File Offset: 0x00001AAC
		// Note: this type is marked as 'beforefieldinit'.
		static SendMouseEvents()
		{
			Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "SendMouseEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr);
			SendMouseEvents.NativeFieldInfoPtr_s_MouseUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "s_MouseUsed");
			SendMouseEvents.NativeFieldInfoPtr_m_LastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_LastHit");
			SendMouseEvents.NativeFieldInfoPtr_m_MouseDownHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_MouseDownHit");
			SendMouseEvents.NativeFieldInfoPtr_m_CurrentHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_CurrentHit");
			SendMouseEvents.NativeFieldInfoPtr_m_Cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_Cameras");
			SendMouseEvents.NativeMethodInfoPtr_SetMouseMoved_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, 100663349);
			SendMouseEvents.NativeMethodInfoPtr_DoSendMouseEvents_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, 100663350);
			SendMouseEvents.NativeMethodInfoPtr_SendEvents_Private_Static_Void_Int32_HitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, 100663351);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000397C File Offset: 0x00001B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512036, XrefRangeEnd = 512040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMouseMoved()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.NativeMethodInfoPtr_SetMouseMoved_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000039A4 File Offset: 0x00001BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512040, XrefRangeEnd = 512202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoSendMouseEvents(int skipRTCameras)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipRTCameras;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.NativeMethodInfoPtr_DoSendMouseEvents_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000039D8 File Offset: 0x00001BD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 512272, RefRangeEnd = 512273, XrefRangeStart = 512202, XrefRangeEnd = 512272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendEvents(int i, SendMouseEvents.HitInfo hit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hit));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.NativeMethodInfoPtr_SendEvents_Private_Static_Void_Int32_HitInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000221B File Offset: 0x0000041B
		public SendMouseEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00003A24 File Offset: 0x00001C24
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002224 File Offset: 0x00000424
		public unsafe static bool s_MouseUsed
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_s_MouseUsed, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_s_MouseUsed, (void*)(&value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00003A40 File Offset: 0x00001C40
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002232 File Offset: 0x00000432
		public unsafe static Il2CppReferenceArray<SendMouseEvents.HitInfo> m_LastHit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_m_LastHit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SendMouseEvents.HitInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_m_LastHit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003A68 File Offset: 0x00001C68
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002244 File Offset: 0x00000444
		public unsafe static Il2CppReferenceArray<SendMouseEvents.HitInfo> m_MouseDownHit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_m_MouseDownHit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SendMouseEvents.HitInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_m_MouseDownHit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00003A90 File Offset: 0x00001C90
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002256 File Offset: 0x00000456
		public unsafe static Il2CppReferenceArray<SendMouseEvents.HitInfo> m_CurrentHit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_m_CurrentHit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SendMouseEvents.HitInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_m_CurrentHit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00003AB8 File Offset: 0x00001CB8
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002268 File Offset: 0x00000468
		public unsafe static Il2CppReferenceArray<Camera> m_Cameras
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_m_Cameras, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_m_Cameras, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_s_MouseUsed;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_m_LastHit;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseDownHit;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentHit;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_m_Cameras;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_SetMouseMoved_Private_Static_Void_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_DoSendMouseEvents_Private_Static_Void_Int32_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_SendEvents_Private_Static_Void_Int32_HitInfo_0;

		// Token: 0x04000078 RID: 120
		public const int m_HitIndexGUI = 0;

		// Token: 0x04000079 RID: 121
		public const int m_HitIndexPhysics3D = 1;

		// Token: 0x0400007A RID: 122
		public const int m_HitIndexPhysics2D = 2;

		// Token: 0x02000020 RID: 32
		public sealed class HitInfo : ValueType
		{
			// Token: 0x060000D5 RID: 213 RVA: 0x00003DA4 File Offset: 0x00001FA4
			// Note: this type is marked as 'beforefieldinit'.
			static HitInfo()
			{
				Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "HitInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr);
				SendMouseEvents.HitInfo.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr, "target");
				SendMouseEvents.HitInfo.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr, "camera");
				SendMouseEvents.HitInfo.NativeMethodInfoPtr_SendMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr, 100663353);
				SendMouseEvents.HitInfo.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_HitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr, 100663354);
				SendMouseEvents.HitInfo.NativeMethodInfoPtr_Compare_Public_Static_Boolean_HitInfo_HitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr, 100663355);
			}

			// Token: 0x060000D6 RID: 214 RVA: 0x00003E34 File Offset: 0x00002034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511967, XrefRangeEnd = 511968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SendMessage(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.HitInfo.NativeMethodInfoPtr_SendMessage_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x00003E7C File Offset: 0x0000207C
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 511992, RefRangeEnd = 511998, XrefRangeStart = 511968, XrefRangeEnd = 511992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static implicit operator bool(SendMouseEvents.HitInfo exists)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(exists));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.HitInfo.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_HitInfo_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000D8 RID: 216 RVA: 0x00003EC4 File Offset: 0x000020C4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 512034, RefRangeEnd = 512036, XrefRangeStart = 511998, XrefRangeEnd = 512034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.HitInfo.NativeMethodInfoPtr_Compare_Public_Static_Boolean_HitInfo_HitInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x0000249B File Offset: 0x0000069B
			public HitInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000DA RID: 218 RVA: 0x000024A4 File Offset: 0x000006A4
			public HitInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr))
			{
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060000DB RID: 219 RVA: 0x00003F24 File Offset: 0x00002124
			// (set) Token: 0x060000DC RID: 220 RVA: 0x000024B6 File Offset: 0x000006B6
			public unsafe GameObject target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendMouseEvents.HitInfo.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendMouseEvents.HitInfo.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060000DD RID: 221 RVA: 0x00003F54 File Offset: 0x00002154
			// (set) Token: 0x060000DE RID: 222 RVA: 0x000024D5 File Offset: 0x000006D5
			public unsafe Camera camera
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendMouseEvents.HitInfo.NativeFieldInfoPtr_camera);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendMouseEvents.HitInfo.NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400009E RID: 158
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400009F RID: 159
			private static readonly IntPtr NativeFieldInfoPtr_camera;

			// Token: 0x040000A0 RID: 160
			private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_0;

			// Token: 0x040000A1 RID: 161
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_HitInfo_0;

			// Token: 0x040000A2 RID: 162
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_HitInfo_HitInfo_0;
		}
	}
}

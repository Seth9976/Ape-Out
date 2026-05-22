using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	public class CharacterController : Collider
	{
		// Token: 0x06000103 RID: 259 RVA: 0x000061E8 File Offset: 0x000043E8
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterController()
		{
			Il2CppClassPointerStore<CharacterController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "CharacterController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterController>.NativeClassPtr);
			CharacterController.NativeMethodInfoPtr_Move_Public_CollisionFlags_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterController>.NativeClassPtr, 100663343);
			CharacterController.NativeMethodInfoPtr_get_radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterController>.NativeClassPtr, 100663344);
			CharacterController.NativeMethodInfoPtr_get_height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterController>.NativeClassPtr, 100663345);
			CharacterController.NativeMethodInfoPtr_get_center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterController>.NativeClassPtr, 100663346);
			CharacterController.NativeMethodInfoPtr_get_slopeLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterController>.NativeClassPtr, 100663347);
			CharacterController.NativeMethodInfoPtr_get_stepOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterController>.NativeClassPtr, 100663348);
			CharacterController.NativeMethodInfoPtr_Move_Injected_Private_CollisionFlags_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterController>.NativeClassPtr, 100663349);
			CharacterController.NativeMethodInfoPtr_get_center_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterController>.NativeClassPtr, 100663350);
			CharacterController.get_isGroundedDelegateField = IL2CPP.ResolveICall<CharacterController.get_isGroundedDelegate>("UnityEngine.CharacterController::get_isGrounded");
			CharacterController.get_collisionFlagsDelegateField = IL2CPP.ResolveICall<CharacterController.get_collisionFlagsDelegate>("UnityEngine.CharacterController::get_collisionFlags");
			CharacterController.set_radiusDelegateField = IL2CPP.ResolveICall<CharacterController.set_radiusDelegate>("UnityEngine.CharacterController::set_radius");
			CharacterController.set_heightDelegateField = IL2CPP.ResolveICall<CharacterController.set_heightDelegate>("UnityEngine.CharacterController::set_height");
			CharacterController.set_slopeLimitDelegateField = IL2CPP.ResolveICall<CharacterController.set_slopeLimitDelegate>("UnityEngine.CharacterController::set_slopeLimit");
			CharacterController.set_stepOffsetDelegateField = IL2CPP.ResolveICall<CharacterController.set_stepOffsetDelegate>("UnityEngine.CharacterController::set_stepOffset");
			CharacterController.get_skinWidthDelegateField = IL2CPP.ResolveICall<CharacterController.get_skinWidthDelegate>("UnityEngine.CharacterController::get_skinWidth");
			CharacterController.set_skinWidthDelegateField = IL2CPP.ResolveICall<CharacterController.set_skinWidthDelegate>("UnityEngine.CharacterController::set_skinWidth");
			CharacterController.get_minMoveDistanceDelegateField = IL2CPP.ResolveICall<CharacterController.get_minMoveDistanceDelegate>("UnityEngine.CharacterController::get_minMoveDistance");
			CharacterController.set_minMoveDistanceDelegateField = IL2CPP.ResolveICall<CharacterController.set_minMoveDistanceDelegate>("UnityEngine.CharacterController::set_minMoveDistance");
			CharacterController.get_detectCollisionsDelegateField = IL2CPP.ResolveICall<CharacterController.get_detectCollisionsDelegate>("UnityEngine.CharacterController::get_detectCollisions");
			CharacterController.set_detectCollisionsDelegateField = IL2CPP.ResolveICall<CharacterController.set_detectCollisionsDelegate>("UnityEngine.CharacterController::set_detectCollisions");
			CharacterController.get_enableOverlapRecoveryDelegateField = IL2CPP.ResolveICall<CharacterController.get_enableOverlapRecoveryDelegate>("UnityEngine.CharacterController::get_enableOverlapRecovery");
			CharacterController.set_enableOverlapRecoveryDelegateField = IL2CPP.ResolveICall<CharacterController.set_enableOverlapRecoveryDelegate>("UnityEngine.CharacterController::set_enableOverlapRecovery");
			CharacterController.SimpleMove_InjectedDelegateField = IL2CPP.ResolveICall<CharacterController.SimpleMove_InjectedDelegate>("UnityEngine.CharacterController::SimpleMove_Injected");
			CharacterController.get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<CharacterController.get_velocity_InjectedDelegate>("UnityEngine.CharacterController::get_velocity_Injected");
			CharacterController.set_center_InjectedDelegateField = IL2CPP.ResolveICall<CharacterController.set_center_InjectedDelegate>("UnityEngine.CharacterController::set_center_Injected");
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000063B8 File Offset: 0x000045B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513643, XrefRangeEnd = 513645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollisionFlags Move(Vector3 motion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motion;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterController.NativeMethodInfoPtr_Move_Public_CollisionFlags_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00006404 File Offset: 0x00004604
		// (set) Token: 0x06000111 RID: 273 RVA: 0x000029EC File Offset: 0x00000BEC
		public unsafe float radius
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513645, XrefRangeEnd = 513649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterController.NativeMethodInfoPtr_get_radius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				CharacterController.set_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00006440 File Offset: 0x00004640
		// (set) Token: 0x06000112 RID: 274 RVA: 0x000029FF File Offset: 0x00000BFF
		public unsafe float height
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513649, XrefRangeEnd = 513653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterController.NativeMethodInfoPtr_get_height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				CharacterController.set_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000647C File Offset: 0x0000467C
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002A12 File Offset: 0x00000C12
		public unsafe Vector3 center
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513653, XrefRangeEnd = 513655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterController.NativeMethodInfoPtr_get_center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000064B8 File Offset: 0x000046B8
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002A1C File Offset: 0x00000C1C
		public unsafe float slopeLimit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513655, XrefRangeEnd = 513659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterController.NativeMethodInfoPtr_get_slopeLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				CharacterController.set_slopeLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000064F4 File Offset: 0x000046F4
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00002A2F File Offset: 0x00000C2F
		public unsafe float stepOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513659, XrefRangeEnd = 513663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterController.NativeMethodInfoPtr_get_stepOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				CharacterController.set_stepOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00006530 File Offset: 0x00004730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513663, XrefRangeEnd = 513667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollisionFlags Move_Injected(ref Vector3 motion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &motion;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterController.NativeMethodInfoPtr_Move_Injected_Private_CollisionFlags_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000657C File Offset: 0x0000477C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513667, XrefRangeEnd = 513671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_center_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterController.NativeMethodInfoPtr_get_center_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000029B5 File Offset: 0x00000BB5
		public CharacterController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000029BE File Offset: 0x00000BBE
		public bool SimpleMove(Vector3 speed)
		{
			return this.SimpleMove_Injected(ref speed);
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000065BC File Offset: 0x000047BC
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.get_velocity_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000029C8 File Offset: 0x00000BC8
		public bool isGrounded
		{
			get
			{
				return CharacterController.get_isGroundedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000029DA File Offset: 0x00000BDA
		public CollisionFlags collisionFlags
		{
			get
			{
				return CharacterController.get_collisionFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00002A42 File Offset: 0x00000C42
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002A54 File Offset: 0x00000C54
		public float skinWidth
		{
			get
			{
				return CharacterController.get_skinWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_skinWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002A67 File Offset: 0x00000C67
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002A79 File Offset: 0x00000C79
		public float minMoveDistance
		{
			get
			{
				return CharacterController.get_minMoveDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_minMoveDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00002A8C File Offset: 0x00000C8C
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002A9E File Offset: 0x00000C9E
		public bool detectCollisions
		{
			get
			{
				return CharacterController.get_detectCollisionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_detectCollisionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00002AB1 File Offset: 0x00000CB1
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002AC3 File Offset: 0x00000CC3
		public bool enableOverlapRecovery
		{
			get
			{
				return CharacterController.get_enableOverlapRecoveryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_enableOverlapRecoveryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002AD6 File Offset: 0x00000CD6
		public bool SimpleMove_Injected(ref Vector3 speed)
		{
			return CharacterController.SimpleMove_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref speed);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002AE9 File Offset: 0x00000CE9
		public void get_velocity_Injected(out Vector3 ret)
		{
			CharacterController.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002AFC File Offset: 0x00000CFC
		public void set_center_Injected(ref Vector3 value)
		{
			CharacterController.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_Move_Public_CollisionFlags_Vector3_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_get_radius_Public_get_Single_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Single_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_get_center_Public_get_Vector3_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_get_slopeLimit_Public_get_Single_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_get_stepOffset_Public_get_Single_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_Move_Injected_Private_CollisionFlags_byref_Vector3_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_get_center_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x040000AF RID: 175
		private static readonly CharacterController.get_isGroundedDelegate get_isGroundedDelegateField;

		// Token: 0x040000B0 RID: 176
		private static readonly CharacterController.get_collisionFlagsDelegate get_collisionFlagsDelegateField;

		// Token: 0x040000B1 RID: 177
		private static readonly CharacterController.set_radiusDelegate set_radiusDelegateField;

		// Token: 0x040000B2 RID: 178
		private static readonly CharacterController.set_heightDelegate set_heightDelegateField;

		// Token: 0x040000B3 RID: 179
		private static readonly CharacterController.set_slopeLimitDelegate set_slopeLimitDelegateField;

		// Token: 0x040000B4 RID: 180
		private static readonly CharacterController.set_stepOffsetDelegate set_stepOffsetDelegateField;

		// Token: 0x040000B5 RID: 181
		private static readonly CharacterController.get_skinWidthDelegate get_skinWidthDelegateField;

		// Token: 0x040000B6 RID: 182
		private static readonly CharacterController.set_skinWidthDelegate set_skinWidthDelegateField;

		// Token: 0x040000B7 RID: 183
		private static readonly CharacterController.get_minMoveDistanceDelegate get_minMoveDistanceDelegateField;

		// Token: 0x040000B8 RID: 184
		private static readonly CharacterController.set_minMoveDistanceDelegate set_minMoveDistanceDelegateField;

		// Token: 0x040000B9 RID: 185
		private static readonly CharacterController.get_detectCollisionsDelegate get_detectCollisionsDelegateField;

		// Token: 0x040000BA RID: 186
		private static readonly CharacterController.set_detectCollisionsDelegate set_detectCollisionsDelegateField;

		// Token: 0x040000BB RID: 187
		private static readonly CharacterController.get_enableOverlapRecoveryDelegate get_enableOverlapRecoveryDelegateField;

		// Token: 0x040000BC RID: 188
		private static readonly CharacterController.set_enableOverlapRecoveryDelegate set_enableOverlapRecoveryDelegateField;

		// Token: 0x040000BD RID: 189
		private static readonly CharacterController.SimpleMove_InjectedDelegate SimpleMove_InjectedDelegateField;

		// Token: 0x040000BE RID: 190
		private static readonly CharacterController.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField;

		// Token: 0x040000BF RID: 191
		private static readonly CharacterController.set_center_InjectedDelegate set_center_InjectedDelegateField;

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x06000410 RID: 1040
		private delegate bool get_isGroundedDelegate(IntPtr @this);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x06000412 RID: 1042
		private delegate CollisionFlags get_collisionFlagsDelegate(IntPtr @this);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x06000414 RID: 1044
		private delegate void set_radiusDelegate(IntPtr @this, float value);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x06000416 RID: 1046
		private delegate void set_heightDelegate(IntPtr @this, float value);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x06000418 RID: 1048
		private delegate void set_slopeLimitDelegate(IntPtr @this, float value);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x0600041A RID: 1050
		private delegate void set_stepOffsetDelegate(IntPtr @this, float value);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x0600041C RID: 1052
		private delegate float get_skinWidthDelegate(IntPtr @this);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x0600041E RID: 1054
		private delegate void set_skinWidthDelegate(IntPtr @this, float value);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x06000420 RID: 1056
		private delegate float get_minMoveDistanceDelegate(IntPtr @this);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x06000422 RID: 1058
		private delegate void set_minMoveDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x06000424 RID: 1060
		private delegate bool get_detectCollisionsDelegate(IntPtr @this);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x06000426 RID: 1062
		private delegate void set_detectCollisionsDelegate(IntPtr @this, bool value);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x06000428 RID: 1064
		private delegate bool get_enableOverlapRecoveryDelegate(IntPtr @this);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x0600042A RID: 1066
		private delegate void set_enableOverlapRecoveryDelegate(IntPtr @this, bool value);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x0600042C RID: 1068
		private delegate bool SimpleMove_InjectedDelegate(IntPtr @this, IntPtr speed);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x0600042E RID: 1070
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x06000430 RID: 1072
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}

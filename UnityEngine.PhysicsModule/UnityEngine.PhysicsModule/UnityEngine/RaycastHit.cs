using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	[StructLayout(2)]
	public struct RaycastHit
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00004B84 File Offset: 0x00002D84
		// Note: this type is marked as 'beforefieldinit'.
		static RaycastHit()
		{
			Il2CppClassPointerStore<RaycastHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "RaycastHit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr);
			RaycastHit.NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Point");
			RaycastHit.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Normal");
			RaycastHit.NativeFieldInfoPtr_m_FaceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_FaceID");
			RaycastHit.NativeFieldInfoPtr_m_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Distance");
			RaycastHit.NativeFieldInfoPtr_m_UV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_UV");
			RaycastHit.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Collider");
			RaycastHit.NativeMethodInfoPtr_get_collider_Public_get_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663306);
			RaycastHit.NativeMethodInfoPtr_get_point_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663307);
			RaycastHit.NativeMethodInfoPtr_get_normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663308);
			RaycastHit.NativeMethodInfoPtr_get_distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663309);
			RaycastHit.CalculateRaycastTexCoord_InjectedDelegateField = IL2CPP.ResolveICall<RaycastHit.CalculateRaycastTexCoord_InjectedDelegate>("UnityEngine.RaycastHit::CalculateRaycastTexCoord_Injected");
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00004C8C File Offset: 0x00002E8C
		public unsafe Collider collider
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 513535, RefRangeEnd = 513536, XrefRangeStart = 513529, XrefRangeEnd = 513535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_collider_Public_get_Collider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr3) : null;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00004CC0 File Offset: 0x00002EC0
		// (set) Token: 0x0600005C RID: 92 RVA: 0x000022EF File Offset: 0x000004EF
		public unsafe Vector3 point
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_point_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Point = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00004CF0 File Offset: 0x00002EF0
		// (set) Token: 0x0600005D RID: 93 RVA: 0x000022F9 File Offset: 0x000004F9
		public unsafe Vector3 normal
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_normal_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Normal = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00004D20 File Offset: 0x00002F20
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002312 File Offset: 0x00000512
		public unsafe float distance
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 513070, RefRangeEnd = 513090, XrefRangeStart = 513070, XrefRangeEnd = 513090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_distance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Distance = value;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000022DD File Offset: 0x000004DD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, ref this));
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00004D50 File Offset: 0x00002F50
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002303 File Offset: 0x00000503
		public Vector3 barycentricCoordinate
		{
			get
			{
				return new Vector3(1f - (this.m_UV.y + this.m_UV.x), this.m_UV.x, this.m_UV.y);
			}
			set
			{
				this.m_UV = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00004D9C File Offset: 0x00002F9C
		public int triangleIndex
		{
			get
			{
				return (int)this.m_FaceID;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004DB4 File Offset: 0x00002FB4
		public static Vector2 CalculateRaycastTexCoord(Collider collider, Vector2 uv, Vector3 pos, uint face, int textcoord)
		{
			Vector2 vector;
			RaycastHit.CalculateRaycastTexCoord_Injected(collider, ref uv, ref pos, face, textcoord, out vector);
			return vector;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00004DD4 File Offset: 0x00002FD4
		public Vector2 textureCoord
		{
			get
			{
				return RaycastHit.CalculateRaycastTexCoord(this.collider, this.m_UV, this.m_Point, this.m_FaceID, 0);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00004E04 File Offset: 0x00003004
		public Vector2 textureCoord2
		{
			get
			{
				return RaycastHit.CalculateRaycastTexCoord(this.collider, this.m_UV, this.m_Point, this.m_FaceID, 1);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00004E34 File Offset: 0x00003034
		public Vector2 textureCoord1
		{
			get
			{
				return this.textureCoord2;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00004E4C File Offset: 0x0000304C
		public Transform transform
		{
			get
			{
				Rigidbody rigidbody = this.rigidbody;
				bool flag = rigidbody != null;
				Transform transform;
				if (flag)
				{
					transform = rigidbody.transform;
				}
				else
				{
					bool flag2 = this.collider != null;
					if (flag2)
					{
						transform = this.collider.transform;
					}
					else
					{
						transform = null;
					}
				}
				return transform;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00004E98 File Offset: 0x00003098
		public Rigidbody rigidbody
		{
			get
			{
				return (this.collider != null) ? this.collider.attachedRigidbody : null;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00004EC8 File Offset: 0x000030C8
		public ArticulationBody articulationBody
		{
			get
			{
				return (this.collider != null) ? this.collider.attachedArticulationBody : null;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00004EF8 File Offset: 0x000030F8
		public Vector2 lightmapCoord
		{
			get
			{
				Vector2 vector = RaycastHit.CalculateRaycastTexCoord(this.collider, this.m_UV, this.m_Point, this.m_FaceID, 1);
				bool flag = this.collider.GetComponent<Renderer>() != null;
				if (flag)
				{
					Vector4 lightmapScaleOffset = this.collider.GetComponent<Renderer>().lightmapScaleOffset;
					vector.x = vector.x * lightmapScaleOffset.x + lightmapScaleOffset.z;
					vector.y = vector.y * lightmapScaleOffset.y + lightmapScaleOffset.w;
				}
				return vector;
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000231C File Offset: 0x0000051C
		public static void CalculateRaycastTexCoord_Injected(Collider collider, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret)
		{
			RaycastHit.CalculateRaycastTexCoord_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref uv, ref pos, face, textcoord, out ret);
		}

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_m_Point;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_m_FaceID;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_m_Distance;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_m_UV;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_get_collider_Public_get_Collider_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_point_Public_get_Vector3_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_get_normal_Public_get_Vector3_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_get_distance_Public_get_Single_0;

		// Token: 0x0400003D RID: 61
		[FieldOffset(0)]
		public Vector3 m_Point;

		// Token: 0x0400003E RID: 62
		[FieldOffset(12)]
		public Vector3 m_Normal;

		// Token: 0x0400003F RID: 63
		[FieldOffset(24)]
		public uint m_FaceID;

		// Token: 0x04000040 RID: 64
		[FieldOffset(28)]
		public float m_Distance;

		// Token: 0x04000041 RID: 65
		[FieldOffset(32)]
		public Vector2 m_UV;

		// Token: 0x04000042 RID: 66
		[FieldOffset(40)]
		public int m_Collider;

		// Token: 0x04000043 RID: 67
		private static readonly RaycastHit.CalculateRaycastTexCoord_InjectedDelegate CalculateRaycastTexCoord_InjectedDelegateField;

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x0600038A RID: 906
		private delegate void CalculateRaycastTexCoord_InjectedDelegate(IntPtr collider, IntPtr uv, IntPtr pos, uint face, int textcoord, [Out] IntPtr ret);
	}
}

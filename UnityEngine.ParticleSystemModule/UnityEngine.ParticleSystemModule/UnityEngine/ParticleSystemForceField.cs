using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000033 RID: 51
	public class ParticleSystemForceField : Behaviour
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000027F9 File Offset: 0x000009F9
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000280B File Offset: 0x00000A0B
		public ParticleSystemForceFieldShape shape
		{
			get
			{
				return ParticleSystemForceField.get_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000281E File Offset: 0x00000A1E
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002830 File Offset: 0x00000A30
		public float startRange
		{
			get
			{
				return ParticleSystemForceField.get_startRangeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_startRangeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002843 File Offset: 0x00000A43
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002855 File Offset: 0x00000A55
		public float endRange
		{
			get
			{
				return ParticleSystemForceField.get_endRangeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_endRangeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00002868 File Offset: 0x00000A68
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000287A File Offset: 0x00000A7A
		public float length
		{
			get
			{
				return ParticleSystemForceField.get_lengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_lengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000288D File Offset: 0x00000A8D
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000289F File Offset: 0x00000A9F
		public float gravityFocus
		{
			get
			{
				return ParticleSystemForceField.get_gravityFocusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_gravityFocusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00004A18 File Offset: 0x00002C18
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000028B2 File Offset: 0x00000AB2
		public Vector2 rotationRandomness
		{
			get
			{
				Vector2 vector;
				this.get_rotationRandomness_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_rotationRandomness_Injected(ref value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000028BC File Offset: 0x00000ABC
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000028CE File Offset: 0x00000ACE
		public bool multiplyDragByParticleSize
		{
			get
			{
				return ParticleSystemForceField.get_multiplyDragByParticleSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_multiplyDragByParticleSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000028E1 File Offset: 0x00000AE1
		// (set) Token: 0x060000CD RID: 205 RVA: 0x000028F3 File Offset: 0x00000AF3
		public bool multiplyDragByParticleVelocity
		{
			get
			{
				return ParticleSystemForceField.get_multiplyDragByParticleVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_multiplyDragByParticleVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00004A30 File Offset: 0x00002C30
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002906 File Offset: 0x00000B06
		public Texture3D vectorField
		{
			get
			{
				IntPtr intPtr = ParticleSystemForceField.get_vectorFieldDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
			}
			set
			{
				ParticleSystemForceField.set_vectorFieldDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00004A5C File Offset: 0x00002C5C
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000291E File Offset: 0x00000B1E
		public ParticleSystem.MinMaxCurve directionX
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_directionX_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_directionX_Injected(ref value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00004A74 File Offset: 0x00002C74
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002928 File Offset: 0x00000B28
		public ParticleSystem.MinMaxCurve directionY
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_directionY_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_directionY_Injected(ref value);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00004A8C File Offset: 0x00002C8C
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002932 File Offset: 0x00000B32
		public ParticleSystem.MinMaxCurve directionZ
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_directionZ_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_directionZ_Injected(ref value);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00004AA4 File Offset: 0x00002CA4
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000293C File Offset: 0x00000B3C
		public ParticleSystem.MinMaxCurve gravity
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_gravity_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_gravity_Injected(ref value);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00004ABC File Offset: 0x00002CBC
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002946 File Offset: 0x00000B46
		public ParticleSystem.MinMaxCurve rotationSpeed
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_rotationSpeed_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_rotationSpeed_Injected(ref value);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00004AD4 File Offset: 0x00002CD4
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00002950 File Offset: 0x00000B50
		public ParticleSystem.MinMaxCurve rotationAttraction
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_rotationAttraction_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_rotationAttraction_Injected(ref value);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00004AEC File Offset: 0x00002CEC
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000295A File Offset: 0x00000B5A
		public ParticleSystem.MinMaxCurve drag
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_drag_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_drag_Injected(ref value);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00004B04 File Offset: 0x00002D04
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00002964 File Offset: 0x00000B64
		public ParticleSystem.MinMaxCurve vectorFieldSpeed
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_vectorFieldSpeed_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_vectorFieldSpeed_Injected(ref value);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00004B1C File Offset: 0x00002D1C
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000296E File Offset: 0x00000B6E
		public ParticleSystem.MinMaxCurve vectorFieldAttraction
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_vectorFieldAttraction_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_vectorFieldAttraction_Injected(ref value);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002978 File Offset: 0x00000B78
		public void get_rotationRandomness_Injected(out Vector2 ret)
		{
			ParticleSystemForceField.get_rotationRandomness_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000298B File Offset: 0x00000B8B
		public void set_rotationRandomness_Injected(ref Vector2 value)
		{
			ParticleSystemForceField.set_rotationRandomness_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004B34 File Offset: 0x00002D34
		public unsafe void get_directionX_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_directionX_InjectedDelegate get_directionX_InjectedDelegate = ParticleSystemForceField.get_directionX_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_directionX_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004B5C File Offset: 0x00002D5C
		public unsafe void set_directionX_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_directionX_InjectedDelegate set_directionX_InjectedDelegate = ParticleSystemForceField.set_directionX_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_directionX_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00004B84 File Offset: 0x00002D84
		public unsafe void get_directionY_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_directionY_InjectedDelegate get_directionY_InjectedDelegate = ParticleSystemForceField.get_directionY_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_directionY_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004BAC File Offset: 0x00002DAC
		public unsafe void set_directionY_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_directionY_InjectedDelegate set_directionY_InjectedDelegate = ParticleSystemForceField.set_directionY_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_directionY_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00004BD4 File Offset: 0x00002DD4
		public unsafe void get_directionZ_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_directionZ_InjectedDelegate get_directionZ_InjectedDelegate = ParticleSystemForceField.get_directionZ_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_directionZ_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004BFC File Offset: 0x00002DFC
		public unsafe void set_directionZ_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_directionZ_InjectedDelegate set_directionZ_InjectedDelegate = ParticleSystemForceField.set_directionZ_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_directionZ_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00004C24 File Offset: 0x00002E24
		public unsafe void get_gravity_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_gravity_InjectedDelegate get_gravity_InjectedDelegate = ParticleSystemForceField.get_gravity_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_gravity_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004C4C File Offset: 0x00002E4C
		public unsafe void set_gravity_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_gravity_InjectedDelegate set_gravity_InjectedDelegate = ParticleSystemForceField.set_gravity_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_gravity_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004C74 File Offset: 0x00002E74
		public unsafe void get_rotationSpeed_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_rotationSpeed_InjectedDelegate get_rotationSpeed_InjectedDelegate = ParticleSystemForceField.get_rotationSpeed_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_rotationSpeed_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00004C9C File Offset: 0x00002E9C
		public unsafe void set_rotationSpeed_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_rotationSpeed_InjectedDelegate set_rotationSpeed_InjectedDelegate = ParticleSystemForceField.set_rotationSpeed_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_rotationSpeed_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00004CC4 File Offset: 0x00002EC4
		public unsafe void get_rotationAttraction_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_rotationAttraction_InjectedDelegate get_rotationAttraction_InjectedDelegate = ParticleSystemForceField.get_rotationAttraction_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_rotationAttraction_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00004CEC File Offset: 0x00002EEC
		public unsafe void set_rotationAttraction_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_rotationAttraction_InjectedDelegate set_rotationAttraction_InjectedDelegate = ParticleSystemForceField.set_rotationAttraction_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_rotationAttraction_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00004D14 File Offset: 0x00002F14
		public unsafe void get_drag_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_drag_InjectedDelegate get_drag_InjectedDelegate = ParticleSystemForceField.get_drag_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_drag_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004D3C File Offset: 0x00002F3C
		public unsafe void set_drag_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_drag_InjectedDelegate set_drag_InjectedDelegate = ParticleSystemForceField.set_drag_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_drag_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00004D64 File Offset: 0x00002F64
		public unsafe void get_vectorFieldSpeed_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_vectorFieldSpeed_InjectedDelegate get_vectorFieldSpeed_InjectedDelegate = ParticleSystemForceField.get_vectorFieldSpeed_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_vectorFieldSpeed_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00004D8C File Offset: 0x00002F8C
		public unsafe void set_vectorFieldSpeed_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_vectorFieldSpeed_InjectedDelegate set_vectorFieldSpeed_InjectedDelegate = ParticleSystemForceField.set_vectorFieldSpeed_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_vectorFieldSpeed_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00004DB4 File Offset: 0x00002FB4
		public unsafe void get_vectorFieldAttraction_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_vectorFieldAttraction_InjectedDelegate get_vectorFieldAttraction_InjectedDelegate = ParticleSystemForceField.get_vectorFieldAttraction_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_vectorFieldAttraction_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004DDC File Offset: 0x00002FDC
		public unsafe void set_vectorFieldAttraction_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_vectorFieldAttraction_InjectedDelegate set_vectorFieldAttraction_InjectedDelegate = ParticleSystemForceField.set_vectorFieldAttraction_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_vectorFieldAttraction_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x04000162 RID: 354
		private static readonly ParticleSystemForceField.get_shapeDelegate get_shapeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_shapeDelegate>("UnityEngine.ParticleSystemForceField::get_shape");

		// Token: 0x04000163 RID: 355
		private static readonly ParticleSystemForceField.set_shapeDelegate set_shapeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_shapeDelegate>("UnityEngine.ParticleSystemForceField::set_shape");

		// Token: 0x04000164 RID: 356
		private static readonly ParticleSystemForceField.get_startRangeDelegate get_startRangeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_startRangeDelegate>("UnityEngine.ParticleSystemForceField::get_startRange");

		// Token: 0x04000165 RID: 357
		private static readonly ParticleSystemForceField.set_startRangeDelegate set_startRangeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_startRangeDelegate>("UnityEngine.ParticleSystemForceField::set_startRange");

		// Token: 0x04000166 RID: 358
		private static readonly ParticleSystemForceField.get_endRangeDelegate get_endRangeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_endRangeDelegate>("UnityEngine.ParticleSystemForceField::get_endRange");

		// Token: 0x04000167 RID: 359
		private static readonly ParticleSystemForceField.set_endRangeDelegate set_endRangeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_endRangeDelegate>("UnityEngine.ParticleSystemForceField::set_endRange");

		// Token: 0x04000168 RID: 360
		private static readonly ParticleSystemForceField.get_lengthDelegate get_lengthDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_lengthDelegate>("UnityEngine.ParticleSystemForceField::get_length");

		// Token: 0x04000169 RID: 361
		private static readonly ParticleSystemForceField.set_lengthDelegate set_lengthDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_lengthDelegate>("UnityEngine.ParticleSystemForceField::set_length");

		// Token: 0x0400016A RID: 362
		private static readonly ParticleSystemForceField.get_gravityFocusDelegate get_gravityFocusDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_gravityFocusDelegate>("UnityEngine.ParticleSystemForceField::get_gravityFocus");

		// Token: 0x0400016B RID: 363
		private static readonly ParticleSystemForceField.set_gravityFocusDelegate set_gravityFocusDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_gravityFocusDelegate>("UnityEngine.ParticleSystemForceField::set_gravityFocus");

		// Token: 0x0400016C RID: 364
		private static readonly ParticleSystemForceField.get_multiplyDragByParticleSizeDelegate get_multiplyDragByParticleSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_multiplyDragByParticleSizeDelegate>("UnityEngine.ParticleSystemForceField::get_multiplyDragByParticleSize");

		// Token: 0x0400016D RID: 365
		private static readonly ParticleSystemForceField.set_multiplyDragByParticleSizeDelegate set_multiplyDragByParticleSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_multiplyDragByParticleSizeDelegate>("UnityEngine.ParticleSystemForceField::set_multiplyDragByParticleSize");

		// Token: 0x0400016E RID: 366
		private static readonly ParticleSystemForceField.get_multiplyDragByParticleVelocityDelegate get_multiplyDragByParticleVelocityDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_multiplyDragByParticleVelocityDelegate>("UnityEngine.ParticleSystemForceField::get_multiplyDragByParticleVelocity");

		// Token: 0x0400016F RID: 367
		private static readonly ParticleSystemForceField.set_multiplyDragByParticleVelocityDelegate set_multiplyDragByParticleVelocityDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_multiplyDragByParticleVelocityDelegate>("UnityEngine.ParticleSystemForceField::set_multiplyDragByParticleVelocity");

		// Token: 0x04000170 RID: 368
		private static readonly ParticleSystemForceField.get_vectorFieldDelegate get_vectorFieldDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_vectorFieldDelegate>("UnityEngine.ParticleSystemForceField::get_vectorField");

		// Token: 0x04000171 RID: 369
		private static readonly ParticleSystemForceField.set_vectorFieldDelegate set_vectorFieldDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_vectorFieldDelegate>("UnityEngine.ParticleSystemForceField::set_vectorField");

		// Token: 0x04000172 RID: 370
		private static readonly ParticleSystemForceField.get_rotationRandomness_InjectedDelegate get_rotationRandomness_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_rotationRandomness_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_rotationRandomness_Injected");

		// Token: 0x04000173 RID: 371
		private static readonly ParticleSystemForceField.set_rotationRandomness_InjectedDelegate set_rotationRandomness_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_rotationRandomness_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_rotationRandomness_Injected");

		// Token: 0x04000174 RID: 372
		private static readonly ParticleSystemForceField.get_directionX_InjectedDelegate get_directionX_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_directionX_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_directionX_Injected");

		// Token: 0x04000175 RID: 373
		private static readonly ParticleSystemForceField.set_directionX_InjectedDelegate set_directionX_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_directionX_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_directionX_Injected");

		// Token: 0x04000176 RID: 374
		private static readonly ParticleSystemForceField.get_directionY_InjectedDelegate get_directionY_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_directionY_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_directionY_Injected");

		// Token: 0x04000177 RID: 375
		private static readonly ParticleSystemForceField.set_directionY_InjectedDelegate set_directionY_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_directionY_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_directionY_Injected");

		// Token: 0x04000178 RID: 376
		private static readonly ParticleSystemForceField.get_directionZ_InjectedDelegate get_directionZ_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_directionZ_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_directionZ_Injected");

		// Token: 0x04000179 RID: 377
		private static readonly ParticleSystemForceField.set_directionZ_InjectedDelegate set_directionZ_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_directionZ_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_directionZ_Injected");

		// Token: 0x0400017A RID: 378
		private static readonly ParticleSystemForceField.get_gravity_InjectedDelegate get_gravity_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_gravity_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_gravity_Injected");

		// Token: 0x0400017B RID: 379
		private static readonly ParticleSystemForceField.set_gravity_InjectedDelegate set_gravity_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_gravity_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_gravity_Injected");

		// Token: 0x0400017C RID: 380
		private static readonly ParticleSystemForceField.get_rotationSpeed_InjectedDelegate get_rotationSpeed_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_rotationSpeed_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_rotationSpeed_Injected");

		// Token: 0x0400017D RID: 381
		private static readonly ParticleSystemForceField.set_rotationSpeed_InjectedDelegate set_rotationSpeed_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_rotationSpeed_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_rotationSpeed_Injected");

		// Token: 0x0400017E RID: 382
		private static readonly ParticleSystemForceField.get_rotationAttraction_InjectedDelegate get_rotationAttraction_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_rotationAttraction_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_rotationAttraction_Injected");

		// Token: 0x0400017F RID: 383
		private static readonly ParticleSystemForceField.set_rotationAttraction_InjectedDelegate set_rotationAttraction_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_rotationAttraction_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_rotationAttraction_Injected");

		// Token: 0x04000180 RID: 384
		private static readonly ParticleSystemForceField.get_drag_InjectedDelegate get_drag_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_drag_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_drag_Injected");

		// Token: 0x04000181 RID: 385
		private static readonly ParticleSystemForceField.set_drag_InjectedDelegate set_drag_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_drag_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_drag_Injected");

		// Token: 0x04000182 RID: 386
		private static readonly ParticleSystemForceField.get_vectorFieldSpeed_InjectedDelegate get_vectorFieldSpeed_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_vectorFieldSpeed_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_vectorFieldSpeed_Injected");

		// Token: 0x04000183 RID: 387
		private static readonly ParticleSystemForceField.set_vectorFieldSpeed_InjectedDelegate set_vectorFieldSpeed_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_vectorFieldSpeed_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_vectorFieldSpeed_Injected");

		// Token: 0x04000184 RID: 388
		private static readonly ParticleSystemForceField.get_vectorFieldAttraction_InjectedDelegate get_vectorFieldAttraction_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_vectorFieldAttraction_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_vectorFieldAttraction_Injected");

		// Token: 0x04000185 RID: 389
		private static readonly ParticleSystemForceField.set_vectorFieldAttraction_InjectedDelegate set_vectorFieldAttraction_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_vectorFieldAttraction_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_vectorFieldAttraction_Injected");

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060001EA RID: 490
		private delegate ParticleSystemForceFieldShape get_shapeDelegate(IntPtr @this);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060001EC RID: 492
		private delegate void set_shapeDelegate(IntPtr @this, ParticleSystemForceFieldShape value);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x060001EE RID: 494
		private delegate float get_startRangeDelegate(IntPtr @this);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x060001F0 RID: 496
		private delegate void set_startRangeDelegate(IntPtr @this, float value);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x060001F2 RID: 498
		private delegate float get_endRangeDelegate(IntPtr @this);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x060001F4 RID: 500
		private delegate void set_endRangeDelegate(IntPtr @this, float value);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x060001F6 RID: 502
		private delegate float get_lengthDelegate(IntPtr @this);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x060001F8 RID: 504
		private delegate void set_lengthDelegate(IntPtr @this, float value);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x060001FA RID: 506
		private delegate float get_gravityFocusDelegate(IntPtr @this);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x060001FC RID: 508
		private delegate void set_gravityFocusDelegate(IntPtr @this, float value);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x060001FE RID: 510
		private delegate bool get_multiplyDragByParticleSizeDelegate(IntPtr @this);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x06000200 RID: 512
		private delegate void set_multiplyDragByParticleSizeDelegate(IntPtr @this, bool value);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x06000202 RID: 514
		private delegate bool get_multiplyDragByParticleVelocityDelegate(IntPtr @this);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x06000204 RID: 516
		private delegate void set_multiplyDragByParticleVelocityDelegate(IntPtr @this, bool value);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x06000206 RID: 518
		private delegate IntPtr get_vectorFieldDelegate(IntPtr @this);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x06000208 RID: 520
		private delegate void set_vectorFieldDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x0600020A RID: 522
		private delegate void get_rotationRandomness_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x0600020C RID: 524
		private delegate void set_rotationRandomness_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x0600020E RID: 526
		private delegate void get_directionX_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x06000210 RID: 528
		private delegate void set_directionX_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x06000212 RID: 530
		private delegate void get_directionY_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x06000214 RID: 532
		private delegate void set_directionY_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x06000216 RID: 534
		private delegate void get_directionZ_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x06000218 RID: 536
		private delegate void set_directionZ_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x0600021A RID: 538
		private delegate void get_gravity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x0600021C RID: 540
		private delegate void set_gravity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x0600021E RID: 542
		private delegate void get_rotationSpeed_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x06000220 RID: 544
		private delegate void set_rotationSpeed_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x06000222 RID: 546
		private delegate void get_rotationAttraction_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x06000224 RID: 548
		private delegate void set_rotationAttraction_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x06000226 RID: 550
		private delegate void get_drag_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x06000228 RID: 552
		private delegate void set_drag_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000B1 RID: 177
		// (Invoke) Token: 0x0600022A RID: 554
		private delegate void get_vectorFieldSpeed_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000B2 RID: 178
		// (Invoke) Token: 0x0600022C RID: 556
		private delegate void set_vectorFieldSpeed_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x0600022E RID: 558
		private delegate void get_vectorFieldAttraction_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x06000230 RID: 560
		private delegate void set_vectorFieldAttraction_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
